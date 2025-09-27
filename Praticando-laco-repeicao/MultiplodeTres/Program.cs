class Progran
{

    static void Main(string[] args)
    {
        Console.WriteLine("Multiplos de 3 de 0 a 100");
        Console.Clear();
        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine($"{i} é um multiplo de 3");
            }
        }
        Console.WriteLine($"FIM!");
    }
}
