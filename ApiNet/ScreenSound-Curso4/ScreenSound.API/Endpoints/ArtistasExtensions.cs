using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Dados.Models;

namespace ScreenSound.API.Endpoints;

public static class ArtistasExtensions
{
    public static void AddEndPointsArtistas(this WebApplication app)
    {
        // O grupo base não deve exigir autorização global para permitir a listagem pública de artistas (GET /Artistas).
        // A proteção é aplicada especificamente nos endpoints que dependem do usuário logado.
        var grupBuilder = app.MapGroup("/Artistas").WithTags("Artistas");

        #region Endpoint Artistas
        grupBuilder.MapGet("", ([FromServices] DAL<Artista> dal) =>
        {
            var listaDeArtistas = dal.Listar();
            if (listaDeArtistas is null)
            {
                return Results.NotFound();
            }
            var listaDeArtistaResponse = EntityListToResponseList(listaDeArtistas);
            return Results.Ok(listaDeArtistaResponse);
        });

        grupBuilder.MapGet("{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
        {
            var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
            if (artista is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(EntityToResponse(artista));

        });

        grupBuilder.MapPost("", async ([FromServices] IHostEnvironment env, [FromServices] DAL<Artista> dal, [FromBody] ArtistaRequest artistaRequest) =>
        {

            var nome = artistaRequest.nome.Trim();
            var imagemArtista = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpg";

            var path = Path.Combine(env.ContentRootPath,
                "wwwroot", "FotosPerfil", imagemArtista);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(artistaRequest.fotoPerfil!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);

            var artista = new Artista(artistaRequest.nome, artistaRequest.bio) { FotoPerfil = $"/FotosPerfil/{imagemArtista}" };

            dal.Adicionar(artista);
            return Results.Ok();
        });

        grupBuilder.MapDelete("{id}", ([FromServices] DAL<Artista> dal, int id) =>
        {
            var artista = dal.RecuperarPor(a => a.Id == id);
            if (artista is null)
            {
                return Results.NotFound();
            }
            dal.Deletar(artista);
            return Results.NoContent();

        });

        grupBuilder.MapPut("", ([FromServices] DAL<Artista> dal, [FromBody] ArtistaRequestEdit artistaRequestEdit) =>
        {
            var artistaAAtualizar = dal.RecuperarPor(a => a.Id == artistaRequestEdit.Id);
            if (artistaAAtualizar is null)
            {
                return Results.NotFound();
            }
            artistaAAtualizar.Nome = artistaRequestEdit.nome;
            artistaAAtualizar.Bio = artistaRequestEdit.bio;
            dal.Atualizar(artistaAAtualizar);
            return Results.Ok();
        });

        // CORREÇÃO: .RequireAuthorization() é indispensável aqui porque este endpoint acessa as Claims do usuário logado (context.User.Claims).
        // Sem .RequireAuthorization():
        // 1. O ASP.NET Core não valida a autenticação na rota e não popula o cookie na identidade do usuário.
        // 2. Se a pessoa não estiver autenticada, context.User.Claims fica vazio, lançando InvalidOperationException (erro 500).
        // Com .RequireAuthorization(), o framework valida o Cookie/Token e responde com 401 Unauthorized automaticamente caso não esteja logado.
        grupBuilder.MapPost("avaliacao", (
            HttpContext context,
            [FromBody] AvaliacaoArtistaRequest request,
            [FromServices] DAL<Artista> dalArtista,
            [FromServices] DAL<PerssonWithPermission> dalPessoa
            ) =>
        {
            var artista = dalArtista.RecuperarPor(a => a.Id == request.ArtistaId);
            if (artista is null) return Results.NotFound();
            //contet recuperar o email da pessoa logada de cokesUser
            var email = context.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value
                ?? throw new InvalidOperationException("Pessoa não está conectada");

            var pessoa = dalPessoa
                .RecuperarPor(p => p.Email.Equals(email))
                ?? throw new InvalidOperationException("Pessoa não está conectada");

            var avaliacao = artista.Avaliacoes
                .FirstOrDefault(a => a.ArtistaId == artista.Id && a.PessoaId == pessoa.Id);

            if (avaliacao is null)
            {
                artista.AdicionarNota(pessoa.Id, request.Nota);
            }
            else
            {
                avaliacao.Nota = request.Nota;
            }

            dalArtista.Atualizar(artista);

            return Results.Created();
        }).RequireAuthorization();

        // CORREÇÃO: .RequireAuthorization() é indispensável aqui para garantir que o usuário autenticado
        // tenha sua identidade resolvida via Cookie/Token e recupere apenas sua própria avaliação.
        grupBuilder.MapGet("{id}/avaliacao", (
            int id,
            HttpContext context,
            [FromServices] DAL<Artista> dalArtista,
            [FromServices] DAL<PerssonWithPermission> dalPessoa
        ) =>
        {
            var artista = dalArtista.RecuperarPor(a => a.Id == id);
            if (artista is null) return Results.NotFound();

            var email = context.User.Claims
                .FirstOrDefault(c => c.Type.Equals(ClaimTypes.Email))?.Value
                ?? throw new InvalidOperationException("Não foi encontrado o email da pessoa logada");

            var pessoa = dalPessoa.RecuperarPor(p => p.Email!.Equals(email))
                ?? throw new InvalidOperationException("Não foi encontrado o email da pessoa logada");

            var avaliacao = artista
                .Avaliacoes
                .FirstOrDefault(a => a.ArtistaId == id && a.PessoaId == pessoa.Id);

            if (avaliacao is null) return Results.Ok(new AvaliacaoArtistaResponse(id, 0));
            else return Results.Ok(new AvaliacaoArtistaResponse(id, avaliacao.Nota));
        }).RequireAuthorization();
        #endregion
    }

    private static ICollection<ArtistaResponse> EntityListToResponseList(IEnumerable<Artista> listaDeArtistas)
    {
        return listaDeArtistas.Select(a => EntityToResponse(a)).ToList();
    }

    private static ArtistaResponse EntityToResponse(Artista artista)
    {
        return new ArtistaResponse(artista.Id, artista.Nome, artista.Bio, artista.FotoPerfil)
        {
            Classificacao = artista.Avaliacoes.Select(a => a.Nota).DefaultIfEmpty(0).Average()
        };
    }

}
