public class ProdutoDigital
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = info;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Tamanho: " + InfoTecnica.TamanhoMB + "MB");
        Console.WriteLine("Compatível com: " + InfoTecnica.SistemaOperacional);
    }
}
