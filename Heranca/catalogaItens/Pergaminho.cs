class Pergaminho(string titulo, string mensagem) : ItemDigital(titulo)
{
    private string descricao = mensagem;

    public string MostrarDetalhes()
    {
        return $"\nPergaminho: {titulo}\nDescrição {descricao}";
    }
}