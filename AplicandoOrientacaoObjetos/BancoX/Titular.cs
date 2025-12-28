namespace BancoX
{
    class Titular(string nome, string cpf, DateTime dataNascimento)
    {
        private readonly string _nome = nome;
        private readonly string _cpf = cpf;
        private readonly DateTime _dataNascimento = dataNascimento;

        public string Nome => _nome;

        public string Cpf => _cpf;

        public DateTime DataNascimento => _dataNascimento;

        public void ExibeInfo()
        {
            Console.Write($"\nTitular: {Nome}\n CPF: {Cpf}\n Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}\n");
        }
    }
}