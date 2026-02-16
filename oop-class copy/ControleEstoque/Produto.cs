class Produto(string nome, double preco)
{
    public string Nome { get; set; } = nome;
    public double QtdEstoque { get; set; } = preco;

    public void Retirar(double quantidade)
    {
        if (quantidade > QtdEstoque)
        {
            Console.WriteLine("Quantidade indisponivel no estoque");
            return;
        }
        QtdEstoque -= quantidade;
        ExibirQuantidade();
    }
    public void ExibirQuantidade()
    {
        Console.WriteLine($"Produto: {Nome} - Qtd em estoque: {QtdEstoque}");
    }
}