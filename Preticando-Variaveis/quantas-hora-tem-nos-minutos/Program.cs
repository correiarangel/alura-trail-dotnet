
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quantas horas em em um a quatidade de minutos:\n");

        int oneHour = 60;

        Console.WriteLine("Digite os minutos ex 500:");
        string? input = Console.ReadLine();

        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Digite os minutos ex 500:");
            input = Console.ReadLine();
        }

        double minity = double.Parse(input);
        double douMinity = minity / oneHour;

        if (minity < 60)
        {
            Console.WriteLine($"{(int)douMinity} Minutos");
            return;
        }
        if (minity == 60)
        {
            Console.WriteLine("1 hora");
            return;
        }


        int hours = (int)douMinity;
        int minutys = (int)Math.Floor((douMinity - hours) * oneHour); 
        Console.WriteLine($"{hours} hara(s) {minutys} Minuto(s)");
   }
}