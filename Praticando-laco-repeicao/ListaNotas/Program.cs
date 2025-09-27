
Console.Clear();
List<double> Notas = new List<double> { 6.5, 4.6, 10, 2, 3.4, 8, 9, 5.1, 4.9 };
Console.WriteLine("Lista de notas com for \n");
for (int i = 0; i < Notas.Count; i++)
{

    if (Notas[i] >= 6)
    {
        Console.WriteLine($"Aprovado com a nota: {Notas[i]}");
    }
    else
    {
        Console.WriteLine($"Reprovado com a nota: {Notas[i]}");
    }

}
Console.WriteLine($"\nFIM!");
