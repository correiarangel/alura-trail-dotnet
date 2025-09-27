
internal class Program
{
   private static void Main(string[] args)
   {
      Console.WriteLine("Converte Milhas em Km:\n");

      double onneMilha = 1.609344;

      Console.WriteLine("Digite as milhas:");
      string? input = Console.ReadLine();

      while (string.IsNullOrEmpty(input))
      {

         Console.WriteLine("Digite as milhas:");
         input = Console.ReadLine();
      }

      double milhas = double.Parse(input);
      double km = milhas * onneMilha;
      Console.WriteLine($"{milhas} Milhas = {km} Km");
   }
}