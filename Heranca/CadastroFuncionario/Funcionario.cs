namespace CadastroFuncionario
{
    class Funcionario(string nome, string cargo)
    {
        public string Nome { get; set; } = nome;
        public string Cargo { get; set; } = cargo;

        public override string ToString()
        {
            return $"Nome: {Nome}, Cargo: {Cargo}";
        }
    }
}