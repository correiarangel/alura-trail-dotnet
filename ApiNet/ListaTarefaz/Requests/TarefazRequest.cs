using System.ComponentModel.DataAnnotations;

namespace ListaTarefaz.Requests;

public record TarefazRequest(
    [Required] string Titulo,
    string Descricao,
    DateOnly? DataConclusao = null
);

public record TarefazRequestEdit(
    [Required] string Titulo,
    string Descricao,
    bool Concluida,
    DateOnly? DataConclusao = null
);
