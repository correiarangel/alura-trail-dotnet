internal partial class Program
{

    private static void Main(string[] args)
    {
      var retangulo = new Retangulo();
        Console.WriteLine("\nRetangulo\n");
        CalcArea(retangulo);
    }

    static void CalcArea(Retangulo retangulo)
    {
        Console.WriteLine($"\nCALCULAR AREA RETANGULO\n");

        retangulo.Altura = GetInput("Digite altura: ");
        retangulo.Largura = GetInput("Digite largura: ");
        var area = retangulo.Area();
        Console.WriteLine($"Area do retangulo: {area}");
    
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