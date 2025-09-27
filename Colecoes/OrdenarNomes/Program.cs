string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };

Console.WriteLine("\n [ ORDENAR LISTE ] \n ");

Console.WriteLine("Lista desordenada...\n");
foreach (string n in nomes) Console.WriteLine(n);

Array.Sort(nomes);

Console.WriteLine("\nLista ordenada...\n");
foreach (string n in nomes) Console.WriteLine(n);

Console.WriteLine($"\nO terceiro nome da lista após ordenação é: {nomes[2]}\n");

