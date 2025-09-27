// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calcule sua idade digite o ano de nacimeto!...\n");

string? anoNascimento = Console.ReadLine();

while (string.IsNullOrEmpty(anoNascimento))
{
    Console.WriteLine("Digite o ano de nacimento:");
}

int anoCorrente = DateTime.Now.Year;

int idade = anoCorrente - int.Parse(anoNascimento);

Console.WriteLine($"Você tem:{idade}");




