using CadastroFuncionario;

class Interno(string nome, string cargo, decimal salario) : Funcionario(nome, cargo)
{
    public decimal Salario { get; set; } = salario;

    public override string ToString()
    {
        return $"{base.ToString()}, Salário: {Salario:C}";
    }
}