﻿// See https://aka.ms/new-console-template for more information

internal partial class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("\nBiblioteca\n");
        EventRegister();
    }

    static void EventRegister()
    {
        Console.WriteLine($"\nViagens Tuor***\n");
        
        string passageiro = GetInput("Digite o Passageiro: ");
        
        string destino = GetInput("Digite o destino: ");
        var ticketd = new Ticketd(passageiro, destino);

        Console.WriteLine($"Passagem 001:\n   Passageiro: {ticketd.Person},\n   Destino: {ticketd.Destination}");
    }

    
    static string GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
         
            if (!string.IsNullOrEmpty(input))
            {
                return input;    
            }
            Console.WriteLine("Valor invalido !....");
        }
    }

}