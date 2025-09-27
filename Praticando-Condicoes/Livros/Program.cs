Console.WriteLine("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine());

switch (codigo)
{
    case int n when (n >= 100 && n <= 199):
        Console.WriteLine("Ficção Científica");
        break;
    case int n when (n >= 200 && n <= 299):
        Console.WriteLine("Literatura Clássica");
        break;
    case int n when (n >= 300 && n <= 399):
        Console.WriteLine("Fantasia");
        break;
    case int n when (n >= 400 && n <= 499):
        Console.WriteLine("Romance");
        break;
    case int n when (n >= 500 && n <= 599):
        Console.WriteLine("Suspense/Mistério");
        break;
    case int n when (n >= 600 && n <= 699):
        Console.WriteLine("Não Ficção");
        break;
    case int n when (n >= 700 && n <= 799):
        Console.WriteLine("Biografias/Memórias");
        break;
    case int n when (n >= 800 && n <= 899):
        Console.WriteLine("Distopia");
        break;
    case int n when (n >= 900 && n <= 999):
        Console.WriteLine("Infantojuvenil");
        break;
    default:
        Console.WriteLine("Código inexistente");
        break;
}
