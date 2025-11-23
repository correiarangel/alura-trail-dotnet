using CalculoJuros;

Console.WriteLine("\n*** Criando simulador de transporte urbano ***\n");


List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};

Console.WriteLine("Simulando empréstimos para um valor de R$1000,00 por 12 meses:\n");

foreach (var perfil in perfis)
{
    decimal valorFinal = perfil.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"Valor final do empréstimo para {perfil.GetType().Name}: R${valorFinal:F2}");
}


Console.WriteLine("\n*** Fim da simulação ***\n");