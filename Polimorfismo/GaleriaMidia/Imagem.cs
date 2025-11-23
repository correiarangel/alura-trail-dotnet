class Imagem(string nome, string _resolucao) : Midia(nome)
{
    public string Resolucao { get; set; } = _resolucao;
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome}, Resolução: {Resolucao}");
    }
    
}