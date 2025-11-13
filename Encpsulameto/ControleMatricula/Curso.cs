class Curso(string nome, int vagasTotais)
{
    public string Nome { get; set; } = nome;
    public int VagasTotais { get; private set; } = vagasTotais;
    private List<Estudante> matriculas = [];

    public bool Matricular(Estudante estudante)
    {
        if (matriculas.Count < VagasTotais)
        {
            matriculas.Add(estudante);
            return true;
        }
        else
        {
            Console.WriteLine($"Erro: Não há vagas disponíveis para matrícular, {estudante.Nome} no curso {Nome}.");

            return false;
        }
    }
    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes matriculados no curso {Nome}:");
        foreach (var estudante in matriculas)
        {
            Console.WriteLine($"- {estudante.Nome}");
        }
    }
}