public class Avaliacao
{
    public string Aluno { get; set; }
    public double Nota { get; private set; }

    public void AtribuirNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Nota = nota;
        }
        else
        {
            Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
        }
    }
}