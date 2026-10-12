using ListaTarefaz.Data;
using ListaTarefaz.Models;
using ListaTarefaz.Requests;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefaz;

public static class TarefazEndPoints
{
    public static void MapTarefazEndPoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/tarefaz").WithTags(nameof(Tarefaz));

        group.MapGet("/", async (ListaTarefazContext db) =>
        {
            return await db.Tarefazs.ToListAsync();
        })
        .WithName("GetAllTarefazs");

        group.MapGet("/{id}", async Task<Results<Ok<Tarefaz>, NotFound>> (int id, ListaTarefazContext db) =>
        {
            return await db.Tarefazs.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Tarefaz model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetTarefazById");

        group.MapPost("/", async (TarefazRequest request, ListaTarefazContext db) =>
        {
            var tarefaz = new Tarefaz(request.Titulo, request.Descricao, request.DataConclusao);
            db.Tarefazs.Add(tarefaz);
            await db.SaveChangesAsync();

            return TypedResults.Created($"/tarefaz/{tarefaz.Id}", tarefaz);
        })
        .Accepts<TarefazRequest>("application/json")
        .WithName("CreateTarefaz");

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, TarefazRequestEdit request, ListaTarefazContext db) =>
        {
            var affected = await db.Tarefazs
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Titulo, request.Titulo)
                    .SetProperty(m => m.Descricao, request.Descricao)
                    .SetProperty(m => m.Concluida, request.Concluida)
                    .SetProperty(m => m.DataConclusao, request.DataConclusao)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .Accepts<TarefazRequestEdit>("application/json")
        .WithName("UpdateTarefaz");

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ListaTarefazContext db) =>
        {
            var affected = await db.Tarefazs
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteTarefaz");
    }
}
