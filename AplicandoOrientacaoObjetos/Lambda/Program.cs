/*
Console.WriteLine("LABDA Function is running...\n");

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

numerosPares.ForEach(numero => Console.WriteLine(numero));


Console.WriteLine($"\n {Function.Somar(52, 31)} \n");

public static class Function
{
   public static int Somar(int a, int b) => a + b;
    
}

*/

Console.WriteLine("Inciando Conta...\n");

var titular = new Titular("Rangel", "123.456.789-00", "Rua dos Bobos, 0");
var conta = new Conta(titular, 1234, 56789, 1000.50, 500.00);

conta.ExibirDadosDaConta();