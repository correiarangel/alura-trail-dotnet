internal partial class Program
{
    static string mesg = "Digite uma fraze:";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Conta caracter ]\n");
        var result = GetInput();
        ProcessarInput(result);
        
    }
    static void ProcessarInput(string input)
    {
        Console.Clear();
        Console.WriteLine($"A palavra contem {input.Length} caracters!\n");
    }

    static string GetInput()
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            Console.WriteLine($"Invalido!\n");
        }
    }

}