
using System.IO.Compression;
using System.Threading.Tasks;

internal partial class Program
{
    static int TotalEstoque = 0;
    private static async Task Main(string[] args)
    {
        await Menu();
    }


    static async Task Menu()
    {
        int opcao = await GetInputMenu();

        if (opcao ==0)
        {
            Console.WriteLine($"Estoque: {TotalEstoque}\n");
            Console.WriteLine("Obrigado por usar sistema bom! ");
            return;
        }
        AddProduto();
    }

    static async Task<int> GetInputMenu()
    {

        while (true)
        {
            Console.Clear();
            if (TotalEstoque > 0) Console.WriteLine($"Estoque atualisado: {TotalEstoque}\n");
            Console.WriteLine("\nMenu - Estoque\n");

            Console.WriteLine("Deseja adicionar um produto ao estoque? \n[0]-Não  \n[1]-Sim");
            string? input = Console.ReadLine() ?? string.Empty;
                   
            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                if (real == 0 || real == 1) return real;
            }
            Console.WriteLine("Valor invalido use \n[0]-Não  \n[1]-Sim ");

        }

    }
    static async Task AddProduto()
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Estoque: {TotalEstoque}\n");
            Console.WriteLine("Digite a Quantidade:");
            string? input = Console.ReadLine() ?? string.Empty;

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                TotalEstoque += real;
                await Menu();
                break;
            }

        }
    }

}

