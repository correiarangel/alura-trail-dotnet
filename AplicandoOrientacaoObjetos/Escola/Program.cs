// See https://aka.ms/new-console-template for more information
using Escola;

Console.WriteLine("\nEscola C#");


Aluno aluno1 = new Aluno("Carlos Silva", 20, new List<decimal> { 8.5m, 7.0m, 9.0m });
Aluno aluno2 = new Aluno("Ana Souza", 22, new List<decimal> { 9.5m, 8.0m, 10.0m });     
Disciplina disciplina = new Disciplina
{
    Nome = "Matemática",
    AlunosMatriculados = new List<Aluno> { aluno1, aluno2 }
};  
Professor professor = new Professor("João Pereira", disciplina);    

Console.WriteLine($"\nProfessor: {professor.Nome}");
Console.WriteLine($"Disciplina: {professor.Disciplina.Nome}\n");
Console.WriteLine("Alunos Matriculados:");
foreach (var aluno in professor.Disciplina.AlunosMatriculados)
{
    aluno.ExibirInformacoes();
}   

Console.WriteLine("\nFim do programa Escola C#\n");
