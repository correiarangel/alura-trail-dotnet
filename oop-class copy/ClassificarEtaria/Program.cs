internal partial class Program
{

    private static void Main(string[] args)
    {
        Filme filme = new Filme("Matrix", 16);
        Console.WriteLine("\nClassifica faixa etaria por idade\n");
        Classicar(filme);
    }

    static void Classicar(Filme filme) 
    {
        
        Console.WriteLine($"\nClassificar\n");
        filme.ExibirResultado( GetInput("Digite a idade "));
       
    }

    
    static int GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine()??string.Empty;

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int result))
            {
                return result; 
            }
            Console.WriteLine("Valor invalido !....");
        }
    }

}