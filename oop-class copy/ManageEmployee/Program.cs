using Microsoft.VisualBasic;

internal partial class Program
{

    const string ANALISTA_PROJETOS = "Analista de Projetos";
    const string ASSISTENTE_ADMINISTRATIVO = "Assistente Administrativo";
    const string DESENVOLVEDOR = "Desenvolvedor";
    private static void Main(string[] args)
    {
        var employee = new Employee( name:"Poulo Paulada", ASSISTENTE_ADMINISTRATIVO);
        Console.WriteLine("\nGegerenciamento de funcionários \n");
        bool isRegister = IsRegisterEmployee("Use [P] para promover [S] para sair");

        if (isRegister)
        {
           var input = GetInput("Digite o novo cargo: ");
           employee.SetPosition(input);
        }

        if (!isRegister)
        {
            Console.WriteLine("Saindo...");
            Console.WriteLine("Finalizado...");
        }

    }

    static bool IsRegisterEmployee(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();


            if (string.IsNullOrEmpty(input) && input == "P" || input == "p")
            {
                return true;
            }
            if (string.IsNullOrEmpty(input) && input == "S" || input == "s")
            {
                return false;
            }
            Console.WriteLine("Valor invalido use [P] para promover [S] para sair !....");

        }
    }
    static string GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input.ToUpper();
            }
            Console.WriteLine("Valor invalido !....");
        }
    }


}