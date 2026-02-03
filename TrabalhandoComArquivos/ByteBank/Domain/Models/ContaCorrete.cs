namespace ByteBank.Domain.Models;
class ContaCorrente(decimal saldo, int numeroConta, int agencia, string titular) : IContaBase
{
    public decimal Saldo { get; private set; } = saldo;

    public int NumeroConta { get; } = numeroConta;

    public int Agencia { get; } = agencia;

    public string Titular { get; } = titular;

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("----- Extrato da Conta -----");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Número da Conta: {NumeroConta}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine("----------------------------");
        Console.WriteLine("----------------------------");
    }


    public void Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            return;
        }
        Console.WriteLine("Saldo insuficiente.");

    }

    public void Transferir(decimal valor, IContaBase contaDestino)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine($"Transferência de {valor} realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

}

internal class Cliente(string titularNome)
{
    private readonly string _titularNome = titularNome;

    public string TitularNome { get; } = titularNome;
}