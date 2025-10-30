public class Paciente(int id, string nome, string idade)
{
    public int Id { get; set; } = id;
    public string Nome { get; set; } = nome;
    public string Idade { get; set; } = idade;

    public void ExibirDados()
    {
        Console.WriteLine($"Id: {Id},\n Nome: {Nome},\n Idade: {Idade}");
    }
}