using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Shared.Modelos.Modelos;

public class AvaliacaoArtista
{
    public int ArtistaId { get; set; }
    //virtual é usado para permitir que o Entity Framework Core crie proxies dinâmicos para a navegação de propriedades, permitindo o carregamento tardio (lazy loading) das entidades relacionadas.
    public virtual Artista? Artista { get; set; }
    public int PessoaId { get; set; }
    public int Nota { get; set; }
}
