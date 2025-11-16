namespace CadastroFuncionario
{
    class Freelancer(string nome, string cargo, decimal valorProjeto = 0) : Funcionario(nome, cargo)
    {
        public decimal ValorProjeto { get; set; } = valorProjeto;
        public override string ToString()
        {
            return $"{base.ToString()}, Valor do Projeto: {ValorProjeto:C}";
        }

    }
}