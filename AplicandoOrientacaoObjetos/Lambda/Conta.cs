class Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
{
    public Titular Titular { get; set; } = titular;
    public int Agencia { get; set; } = agencia;
    public int NumeroDaConta { get; set; } = numeroDaConta;
    public double Saldo { get; } = saldo;
    public double Limite { get; set; } = limite;

    public void ExibirDadosDaConta()
    {
        Console.WriteLine($"Titular: {Titular.Nome}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {NumeroDaConta}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Limite: {Limite}");
    }
}