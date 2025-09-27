
using System.IO.Compression;
using System.Threading.Tasks;


internal partial class Program
{

    public static async Task Main(string[] args)
    {
       var aluno = GetInputMenu();
        Console.WriteLine(aluno);
        Console.WriteLine($"Sitema finalizado....");
        return;
    }

    static List<String> GetPessoas()
    {
        List<String> Pessoas = new List<String>();
        for (int i = 0; i < 100; i++)
        {
            Pessoas.Add($"Nome{i}");
        }
        return Pessoas;
    }
    static string GetInputMenu()
    {
        var Pessoas = GetPessoas();
        int contLoop = 0;
        while (true)
        {
            string msg = contLoop > 0 ? "Aluno não encontrado!\nDigite o nome do Aluno:" : "Digite o nome do Aluno:";
            string input = GetInput(msg);
            contLoop++;

            if (!string.IsNullOrEmpty(input))
            {
                var aluno = BuscarAluno(input, Pessoas);
                if (!string.IsNullOrEmpty(aluno)) return aluno;
            }
        }

    }
    static string BuscarAluno(string input, List<string> Pessoas)
    {
        for (int i = 0; i < Pessoas.Count; i++)
        {
            if (Pessoas[i] == input)
            {
                return $"Aluno {input} presente na posição {i}";
            }
        }

        /*List<string> alunos = Pessoas.Where(x => x.Contains(input)).ToList();
        if (alunos.Any())
        {
            var resultAluno = alunos.First();
            var position = resultAluno.Substring(0, resultAluno.Length - 1);
            return $"Aluno {resultAluno} presente na posição {position}";
        }*/
        return string.Empty;
    }
    public static string GetInput(string msg)
    {
        Console.Clear();
        Console.WriteLine("\nBuscar alunos \n");
        Console.WriteLine(msg);
        string input = Console.ReadLine() ?? string.Empty;
        return input;
    }
}



