class ContaBancaria(string titular, double saldoInicial)
{
    public string Titular { get; private set; } = titular;

    private double saldo = saldoInicial;

    public bool Sacar(double valor)
    {
        SegurancaConta seguranca = new SegurancaConta();
        if (seguranca.ValidarSaque(valor))
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Saque não autorizado pela segurança.");
            return false;
        }
    }

    internal class SegurancaConta
    {
        public bool ValidarSaque(double valor)
        {
            return valor <= 1000;
        }
    }
}


/*

Uma classe ContaBancaria, com:

Propriedade pública Titular
Campo privado saldo
Construtor para definir o titular e saldo inicial
Método público Sacar(double valor) que só realiza o saque se a classe interna de segurança permitir
Propriedade Saldo (somente leitura)
Uma classe SegurancaConta (com modificador internal), com:

Um método ValidarSaque(double valor) que apenas autoriza saques de até R$ 1000

*/