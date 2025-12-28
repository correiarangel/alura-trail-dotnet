namespace Escola
{
    class Professor(string nome, Disciplina disciplina)
    {
        public string Nome { get; set; } = nome;
        public Disciplina Disciplina { get; set; } = disciplina;

        public void ExibirInfo()
        {
            Console.WriteLine($"Professor: {Nome}, Disciplina: {Disciplina}");
        }
    }
}