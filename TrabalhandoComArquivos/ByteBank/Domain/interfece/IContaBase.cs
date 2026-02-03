interface IContaBase
{
    void ExibirSaldo();
    void Depositar(decimal valor);
    void Sacar(decimal valor);
    void Transferir(decimal valor, IContaBase contaDestino);
    decimal Saldo { get; }
    int NumeroConta { get; }
    int Agencia { get; }
    string Titular { get; }
}