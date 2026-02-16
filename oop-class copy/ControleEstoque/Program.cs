internal partial class Program
{

    private static void Main(string[] args)
    {
        Produto produto = new Produto("Caneta Azul", 20);
        Console.WriteLine("\nCControle de estoque\n");
        Retirar(produto);
    }

    static void Retirar(Produto produto ) 
    {
        
        Console.WriteLine($"\nRetirada\n");
        produto .Retirar(GetInput("Digite a quantidade para retirar"));
       
    }

    
    static double GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine()??string.Empty;

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (double.TryParse(inputFilter, out double result))
            {
                return result; 
            }
            Console.WriteLine("Valor invalido !....");
        }
    }

}