
internal partial class Program
{
    static string SENHA = "123456";
    static string USER = "ZeAdmin";
    static int NIVEL = 0;
    static string mesg = "Sistema Bom ! Distribuidora só sistemas bom ;)\n";
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nLogin {mesg}\n");
        string user = GetInputString("Digite usuario:");
        string senha = GetInputString("Digite sua senaha:");
        
        Login(user,senha);
    }

    static void Login(string user, string senha)
    {
        if (senha == SENHA && user == USER)
        {
            SetPermissaoLogin(user, NIVEL);
            return;
        }
        Menu(user, senha);        
    }
    static int GetInputInt(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                return real;
            }
            Console.WriteLine($"Valor invalido use {mesg}");

        }
    }
    static void Menu(string user,string senha)
    {
        int opcao = 0;
        while (opcao == 0)
        {
            Console.WriteLine("\nMenu\n");
            Console.WriteLine("\n[1] Cadastrar novo usuário");
            Console.WriteLine("[2] Acessar como convidado");
            Console.WriteLine("[3] Sair\n");

            opcao = GetInputInt("Opções disponiveis");
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"\nSeja bem vindo {user} cadstrado como {GetUserPermission(PermissaoUsuarios.UsuarioCadastrado)}....");
                    USER = user;
                    SENHA= senha;
                    NIVEL = 2;
                    break;
                case 2:
                    Console.WriteLine($"\nSeja bem vindo {user}!\nAcesso concedido como {GetUserPermission(PermissaoUsuarios.Visitante)} em nosso sistema....");
                    break;
                case 3:
                    Console.WriteLine($"\nSistema finalizado!  ");
                    break;
            }
        }
}
    static void SetPermissaoLogin(string user, int nivel)
    {
        switch (nivel)
        {
            case 0:
                Console.WriteLine($"\nAcesso concedido como {GetUserPermission(PermissaoUsuarios.Admin)}....\nSeja bem vindo {user}");
                break;
            case 1:
                Console.WriteLine($"\nAcesso concedido como {GetUserPermission(PermissaoUsuarios.UsuarioCadastrado)}....\nSeja bem vindo {user}");
                break;
            case 2:
                Console.WriteLine($"\nAcesso concedido como {GetUserPermission(PermissaoUsuarios.Visitante)}....\nSeja bem vindo {user}");
                break;      
            default:
                Console.WriteLine($"\nOps! algo errado :\n Verifique senha e usuario !");
                break;
        }

    }
    static string GetInputString(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input??string.Empty;
            }
            Console.WriteLine($"Valor invalido, {mesg}");
        }
    }

    static string GetUserPermission(PermissaoUsuarios permissao)
    {
            
            return permissao switch
            {
                PermissaoUsuarios.Visitante => "Visitante ",
                PermissaoUsuarios.Admin => "Admin",
                PermissaoUsuarios.UsuarioCadastrado => "UsuarioCadastrado ",
                 _ =>  "?",
            };
    }

}
public enum PermissaoUsuarios
{
    Admin = 0,
    UsuarioCadastrado = 1,
    Visitante = 2
}