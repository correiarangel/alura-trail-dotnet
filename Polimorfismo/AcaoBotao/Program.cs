using AcaoBotao;

Console.WriteLine("\n*** Criando simulador de ações em botões de interface gráfica ***\n");




List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};

Console.WriteLine("Executando simulação ações dos botões:\n");    

foreach (IAcaoBotao acao in acoes)
{
    acao.Executar();
}

Console.WriteLine("\n*** Fim do simulador de ações em botões de interface gráfica ***\n");
