namespace BancoX
{
    class Conta(Titular titular, string agencia, string numeroConta, decimal saldo, decimal limite)
    {
        public Titular Titular { get; set; } = titular;
        public string Agencia { get; set; } = agencia;
        public string NumeroConta { get; set; } = numeroConta;
        public decimal Saldo { get; set; } = saldo;
        public decimal Limite { get; set; } = limite;

        public string ObterInformacoesDetalhadas()
        {
            return $"Titular: {Titular.Nome}, CPF: {Titular.Cpf}, Agência: {Agencia}, Número da Conta: {NumeroConta}, Saldo: {Saldo:C}, Limite: {Limite:C}";
        }
    }
}