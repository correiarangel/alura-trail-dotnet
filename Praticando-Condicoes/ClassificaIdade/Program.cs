// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    static double saldo = 190.34;
    static string mesg = "Use numeros de [0 a 9] para idade";
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nClassificação de faixa etaria\n");
        int idadeInput = GetInput(mesg);

        TesteIdade(idadeInput);

    }
/*
Infantil (0 a 12 anos)
Adolescente (13 a 17 anos)
Adulto (18 a 59 anos)
Idoso (60 anos ou mais)
*/
    static void TesteIdade(int idade)
    {

        if (idade >0 && idade <=12 )
        {
            Console.WriteLine($"Classificação  {idade} anos e Infantil");
            return;
        }
        if (idade >=13 && idade <= 17)
        {
             Console.WriteLine($"Classificação  {idade} anos e adolecente");
            return;
        }
        if (idade >=18 && idade < 59)
        {
             Console.WriteLine($"Classificação  {idade} anos e adulto");
            return;
        }
        if (idade >60)
        {
             Console.WriteLine($"Classificação  {idade} anos e idoso");
            return;
        }

        Console.WriteLine("Valor invalido ou algo deu errado valor não foi reconhecido reinicie e siga as intruções....");
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
            Console.WriteLine($"Valor invalido use {mesg}");

        }
    }


}