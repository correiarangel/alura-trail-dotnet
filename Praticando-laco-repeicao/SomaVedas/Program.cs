
using System.Threading.Tasks;

internal partial class Program
{
    static int TotalVendas = 0;
    private static void Main(string[] args)
    {
        AddVendas();
    }

  
    static async Task AddVendas()
    {
        bool isRun = true;
        do
        {
            Console.Clear();
            Console.WriteLine("\nMenu- soma vendas\n");
           
            Console.WriteLine("Digite o valor [1234,65] da venda para Adicionar ao total de vendas");
            Console.WriteLine("Digite [0] para sair e vero o reultado Sair\n");
            string? input = Console.ReadLine()??string.Empty;

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                if(real == 0)isRun = false;
                TotalVendas += real;
            }
            
        } while (isRun);
        Console.WriteLine($"\nTotal de vendas do dia: R$ {TotalVendas.ToString("F2")}\n");
          
    }
  

}
