// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    static double saldo = 190.34;
    static string mesg = "Use [1] para perecivel [2] para não perecivel";
    private static void Main(string[] args)
    {
        Console.WriteLine("\nTranporte BOM Transportadora \nConsulte tipo de produto:\n USE OS NUMEROS: 1 e 2 !\n [1] para perecivel\n[2] para não perecivel\n");
        int typeProd = GetInput(mesg);

        TesteTipodeProduto(typeProd);

    }

    static void TesteTipodeProduto(int type)
    {

        if (type == 1)
        {
            Console.WriteLine($"PRODUTO TIPO {type} NÂO È PERECIVEL!");
            return;
        }
        if (type == 2)
        {
            Console.WriteLine($"ATENÇÂO PRODUTO TIPO {type} È PERECIVEL!");
            return;
        }
        
        Console.WriteLine("Valor invalido use [1] para perecilvel [2] para não perecivel....");


    }
    static int GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                return real;
            }
            Console.WriteLine("Valor invalido use 1/2 ....");

        }
    }


}