Console.WriteLine("\n*** Determinando a situação de um estudante com base na média***\n");


Estudante estudante = new Estudante("Cata Tall");
estudante.Nota1 = 2.5;
estudante.Nota2 = 5.0;
estudante.Nota3 = 3.0;

Console.WriteLine($"Estudante: {estudante.Nome}");
Console.WriteLine($"Média: {estudante.Media():F2}");
Console.WriteLine($"Situação: {estudante.Situacao()}");