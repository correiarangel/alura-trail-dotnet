
Console.Clear();
List<double> Notas = new List<double> {3.3,4.1,7,8,9.5,6.5, 4.6, 10, 2, 3.4, 8, 9, 5.1, 4.9 };
Console.WriteLine("Lista 2 de notas com for \n");
for (int i = 0; i < Notas.Count; i++)
{
   
    if (Notas[i] >= 7)
    {
        Console.WriteLine($"VoCê esta bem, nota: {Notas[i]}");
    }
    else
    {
        Console.WriteLine($"Hum voçè esta mau, nota: {Notas[i]}");
    }

}
Console.WriteLine($"\nFIM!");
