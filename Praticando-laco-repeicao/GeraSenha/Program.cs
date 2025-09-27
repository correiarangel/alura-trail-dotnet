
using System.IO.Compression;
using System.Threading.Tasks;


internal partial class Program
{
    static List<String> filaDesenhas = new List<String>();

    public static async Task Main(string[] args)
    {
        GetInputMenu();
    }

    static void GeerarSenha()
    {
        int senha = 0;
        if (!filaDesenhas.Any())
        {

            senha = 1;
            filaDesenhas.Add(senha.ToString("D3"));
            Console.WriteLine($"\nNova senha: {senha.ToString("D3")} gerada esta na fila.\nCom 0 pessoa na sua frente...");
            return;
        }

        senha = int.Parse(filaDesenhas.Last());
        senha += 1;
        int contFila = filaDesenhas.Count;
        filaDesenhas.Add(senha.ToString("D3"));
        Console.WriteLine($"\nNova senha: {senha.ToString("D3")} gerada esta na fila ...");
        Console.WriteLine($"Com {contFila} pessoa na sua frente...\n");
        return;

    }
    static String AndarFila()
    {
        if (!filaDesenhas.Any())
        {


            Console.WriteLine($"\nNão há pessoas na fila ....");
            return string.Empty;
        }

        var senha = filaDesenhas[0];
        filaDesenhas.RemoveAt(0);
        return senha;
    }
    static void GetInputMenu()
    {
        string input = string.Empty;

        while (true)
        {
            string msg = "Escolha uma opção:\n 1 - Gerar nova senha \n 2 - Chamar próxima senha \n 3 - Sair";
            input = GetInput(msg);
            if (!string.IsNullOrEmpty(input))
            {
                if (input == "1")
                {
                    GeerarSenha();
                }
                else if (input == "2")
                {
                    var s = AndarFila();
                    Console.WriteLine($"\nSenha removida da fila {s}...");
                    Console.WriteLine($"Restão: {filaDesenhas.Count} senhas na fila ...");

                    var senha = filaDesenhas.LastOrDefault();
                    Console.WriteLine($"Proxima senha : {senha}\n");
                }
                else if (input == "3")
                {
                    Console.WriteLine("\nSitema finalizado........\n");
                    return;
                }
                else
                {
                    Console.WriteLine($"\nInvalido digite->\n1 - Gerar nova senha \n2 - Chamar próxima senha \n3 - Sair");
                }
            }
        }

    }

    public static string GetInput(string msg)
    {
        Console.WriteLine("\nMenu do sitema\n");
        Console.WriteLine(msg);
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"DIGITOU {input}");
        return input;
    }
}



