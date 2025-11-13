class Funcionario(string nome, decimal salario)
{
    public string Nome { get; private set; } = nome;
    public decimal Salario { get; private set; } = salario;

    public void ReajustarSalario(decimal value)
    {
        if (value < Salario)
        {
            Console.WriteLine("O novo salario não pode ser inferior a atual!.");
            return ;
        }

        Salario =  value;
        Console.WriteLine($"Salario reajustado.{Salario.ToString("F2")}");
    }
}