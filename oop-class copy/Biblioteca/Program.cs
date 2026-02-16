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
        Console.WriteLine($"\nRegistrar\n");
        
        string title = GetInput("Digite o titulo: ");
        
        string acthor = GetInput("Digite o outor: ");
        var book = new Book()
        {
            Title = title,
            Author = acthor
        };
        Console.WriteLine($"Livro:\n   Titulo: {book.Title},\n   Autor: {book.Author}");
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