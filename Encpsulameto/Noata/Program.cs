// See https://aka.ms/new-console-template for more information
Console.WriteLine("Validação de nota mínima");

Avaliacao avaliacao = new Avaliacao();
avaliacao.Aluno = "João Silva";
avaliacao.AtribuirNota(8.5);
Console.WriteLine($"Aluno: {avaliacao.Aluno}, Nota: {avaliacao.Nota}");

avaliacao.Aluno = "Catatal";
avaliacao.AtribuirNota(11.1);
Console.WriteLine($"Aluno: {avaliacao.Aluno}, Nota: {0}");


avaliacao.Aluno = "Pepi Legal";
avaliacao.AtribuirNota(10);
Console.WriteLine($"Aluno: {avaliacao.Aluno}, Nota: {avaliacao.Nota}");
