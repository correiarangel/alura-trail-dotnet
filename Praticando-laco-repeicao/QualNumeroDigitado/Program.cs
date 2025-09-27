
using System.IO.Compression;
using System.Threading.Tasks;


internal partial class Program
{
    private static async Task Main(string[] args)
    {
      await GetInputMenu();
    }


    static async Task GetInputMenu()
    {
        Random random = new Random();
        int secretyNumber = random.Next(0, 101);
        while (true)
        {
            Console.Clear();

            Console.WriteLine("\nMenu - Qual e o numero JOGO \n");

            Console.WriteLine("Quam e o numero secreto use numeros de 0 a 100");
            string? input = Console.ReadLine() ?? string.Empty;

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                if (real == secretyNumber)
                {
                    Console.WriteLine($"Parabens o numero é [{real}] ");
                    return;

                }
            }
            Console.WriteLine("Valor invalido tente novamete!\nUse numeros de 0 a 100");

        }

    }

}

