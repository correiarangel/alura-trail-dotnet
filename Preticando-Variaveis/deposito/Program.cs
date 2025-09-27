// See https://aka.ms/new-console-template for more information
Console.WriteLine("DOAÇÃO");


Console.WriteLine("Digite o VALOR DA DOAÇÃO:");
string? recebido = Console.ReadLine();
while (string.IsNullOrEmpty(recebido))
{
    Console.WriteLine("Digite o VALOR DA DOAÇÃO:");
    recebido = Console.ReadLine();
}

Console.WriteLine("Doação anônima S/N:");
string? anonima = Console.ReadLine();
while (string.IsNullOrEmpty(anonima))
{
    Console.WriteLine("Doação anônima S/N:");
    anonima = Console.ReadLine();
}
bool isAnonimo = false;
if (anonima.ToUpper() == "S")
{
    isAnonimo = true;
}

Console.WriteLine("Tipo de conta C para corrente / P para poupança:");
string? tipoConta = Console.ReadLine();
if (string.IsNullOrEmpty(tipoConta) )
{
    Console.WriteLine("Tipo de conta C para corrente / P para poupança:");
    tipoConta = Console.ReadLine();
}



Console.WriteLine($"Valor recebido: R$:{recebido}");
Console.WriteLine($"Anonimo: {isAnonimo}");
Console.WriteLine($"Tipo: {tipoConta}");

