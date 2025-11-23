using RelatorioFuncionario;

Console.WriteLine("\n*** Sistema de relatório de funcionários ***\n");

Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());

