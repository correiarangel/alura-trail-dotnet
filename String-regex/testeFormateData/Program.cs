using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

internal partial class Program
{
    static string mesg = "Digite a data (dd/mm/aaaa):";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Valida formato data pt br ]\n");
        GetInput();
        
    }
    static void ProcessarInput(string input)
    {

        string pattern = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/(19|20)\d{2}$";
        bool valid = Regex.IsMatch(input,pattern); 
        if (valid)
        {
            Console.WriteLine("A data está no formato correto ;)");
            return;
        }
        Console.Clear();
        Console.WriteLine("A data está no formato IVALIDO :(\n");
            
    }

    static void GetInput()
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                ProcessarInput(input);
                return;
            }
            Console.WriteLine($"ivalido! {mesg}\n");
        }
    }

}