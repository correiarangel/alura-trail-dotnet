Console.Clear();

Console.WriteLine("\nManipulando listas");

List<string> nomes = new List<string> {"Lúcia","Javé", "Ana", "Carlos", "Mariana", "João" };



Console.WriteLine("\nLista original:");

foreach (var n in nomes)
{
    Console.WriteLine(n);
}
Console.WriteLine("\nApós Sort (ordem alfabética):");


nomes.Sort();

foreach (var no in nomes)
{
    Console.WriteLine(no);
}

//----

Console.WriteLine("\nApós Reverse (ordem invertida):");

nomes.Reverse();

foreach (var no in nomes)
{
    Console.WriteLine(no);
}


Console.WriteLine("\nApós remover o primeiro:");

var fisrtName = nomes.First();
Console.WriteLine($"\nPrimeiro nome {fisrtName}");

nomes.Remove(fisrtName);
foreach (var n in nomes)
{
    Console.WriteLine(n);
} 




Console.WriteLine("\nApós adicioná-lo no fim:");

nomes.Add(fisrtName);

foreach (var n in nomes)
{
    Console.WriteLine(n);
}

Console.WriteLine("\nFim e quem quiser que conte outra!\n");

