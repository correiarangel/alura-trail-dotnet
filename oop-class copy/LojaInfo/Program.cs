internal partial class Program
{

    private static void Main(string[] args)
    {
        InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
        ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
        produto.ExibirDetalhes();

        InformacaoTecnica info2 = new InformacaoTecnica(3800, "LINUX");
        ProdutoDigital produto2 = new ProdutoDigital("Sistema LInux Ubuntu", 0, info);
        produto2.ExibirDetalhes();
    }

}
