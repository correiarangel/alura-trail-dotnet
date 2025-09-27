using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

internal partial class Program
{
    static string mesg = "Digite o texto com as url:";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Remove url alterando para LINK ]\n");
        GetInput();
        
    }
    static void AlteradInput(string input)
    {
        string pattern = @"https?://\S\S+";
        string result = Regex.Replace(input, pattern, "[LINK]");
        Console.WriteLine($"RESULTADO:\n {result}");                   
    }

    static void GetInput()
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                AlteradInput(input);
                return;
            }
            Console.WriteLine($"ivalido! {mesg}\n");
        }
    }

}