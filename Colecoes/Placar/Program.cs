HashSet<int> scores = new HashSet<int>();
Console.WriteLine("\n [ DECIFRA CADEIA DE NUMEROS ] \n ");
scores.Add(150);
scores.Add(90);
scores.Add(200);
scores.Add(120);
scores.Add(150);
scores.Add(80);
scores.Add(180);
scores.Add(200);

var listOrder = scores.OrderByDescending(x => x).ToList();
listOrder.Reverse();
Console.WriteLine("\nPLACAR\n");

foreach (var item in listOrder)
{
    Console.WriteLine($" {item} ");
}


