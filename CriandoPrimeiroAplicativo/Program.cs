


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

Dictionary<string, List<int>> dicBandasAvaliacoes = new Dictionary<string, List<int>>();
dicBandasAvaliacoes.Add("Pink Floyd", new List<int>() { 10, 9, 8 });
dicBandasAvaliacoes.Add("The Beatles", new List<int>() { 10, 10, 9 });
dicBandasAvaliacoes.Add("U2", new List<int>() { 8, 9, 7 });




void ExibeLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            ListarBandaTrgistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ListaAvaliacoesDasBandas();
            break;

        case -1:
            Console.WriteLine("\nObrigado por utilizar o Screen Sound. Até a próxima!\n");
            break;

        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.\n");
            ExibirOpcoesDoMenu();
            break;
    }

}

void ListaAvaliacoesDasBandas()
{
    Console.Clear();
    ExibirTituloDoPrograma("Média de avaliações das bandas");
    Console.Write("Digite o nome da banda que deseja ver a média das avaliações: ");
    string nomeDoCarro = Console.ReadLine();

    if (dicBandasAvaliacoes.ContainsKey(nomeDoCarro))
    {
        List<int> vendas = dicBandasAvaliacoes[nomeDoCarro];
        double media = vendas.Average();
        Console.WriteLine($"A média de notas da banda: {nomeDoCarro} é: {media}");
        Console.WriteLine("\n Digite qualquer tecla para voltar ao menu principal..");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDoCarro} não foi encontrado na lista.");
        Console.WriteLine("\n Digite qualquer tecla para voltar ao menu principal..");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}



void ListarBandaTrgistradas()
{
    ExibirTituloDoPrograma("As bandas registradas são:");
    foreach (string banda in dicBandasAvaliacoes.Keys)
    {
        Console.WriteLine($"- {banda}");
    }
    Console.WriteLine("\n Digite qualquer tecla para voltar ao menu principal..");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    dicBandasAvaliacoes.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!\n");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void ExibirTituloDoPrograma(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine("\n");
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
    Console.WriteLine("\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDoPrograma($"Avaliar a banda .....");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine();

    if (dicBandasAvaliacoes.ContainsKey(nomeDaBanda))
    {

        Console.WriteLine("Digite a sua avaliação de 0 a 10: ");
        string avaliacaoStr = Console.ReadLine();

        int avaliacao = int.Parse(avaliacaoStr);

        dicBandasAvaliacoes[nomeDaBanda].Add(avaliacao);
        Console.WriteLine($"\nA avaliação de {avaliacao} foi registrada com sucesso para a banda {nomeDaBanda}!\n");
        Console.WriteLine("\n Digite qualquer tecla para voltar ao menu principal..");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.\n");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMensagemDeBoasVindas()
{
    ExibeLogo();
    ExibirTituloDoPrograma(mensagemDeBoasVindas);
    ExibirOpcoesDoMenu();
}

ExibirMensagemDeBoasVindas();





/*

Console.Write("\nDigite a sua nota: ");
string notaMediaStr = Console.ReadLine();

int notaMedia = int.Parse(notaMediaStr);

if (notaMedia > 0)
{
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
}



Console.WriteLine("\nLista de Linguagens de Programação:");
List<String> linguagens = new List<string> { "C#", "Java", "JavaScript" };

Console.WriteLine(linguagens[0]);


foreach (string linguagem in linguagens)
{
    Console.WriteLine(linguagem);
}

Console.WriteLine("\nAdicionando mais linguagens...");
linguagens.Add("Python");
linguagens.Add("C++");  
linguagens.Add("Ruby");

foreach (string linguagem in linguagens)
{
    Console.WriteLine(linguagem);
}

Console.WriteLine($"\nDigite a posição da linguagem que deseja exibir: ");
string posicaoStr = Console.ReadLine();
int posicao = int.Parse(posicaoStr);
Console.WriteLine($"\nA linguagem na posição {posicao} é: {linguagens[posicao]}");


*/


/*
using System;


internal partial class Program
{
    private static async Task Main(string[] args)
    {
      await GetInputMenu();
    }


    static async Task GetInputMenu()
    {
        Random random = new Random();
        int secretyNumber = random.Next(0, 101);
        while (true)
        {
            Console.Clear();

            Console.WriteLine("\nMenu - Qual e o numero JOGO \n");

            Console.WriteLine("Quam e o numero secreto use numeros de 0 a 100");
            string? input = Console.ReadLine() ?? string.Empty;

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                if (real == secretyNumber)
                {
                    Console.WriteLine($"Parabens o numero é [{real}] ");
                    return;

                }
            }
            Console.WriteLine("Valor invalido tente novamete!\nUse numeros de 0 a 100");

        }

    }

}
*/
/*
Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.
*/

/*
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 , 11, 12, 13, 14, 15 ,16, 17, 18, 19, 20 ,21, 22, 23, 24, 25 ,26, 27, 28, 29, 30 ,31, 32, 33, 34, 35 ,36, 37, 38, 39, 40 ,41, 42, 43, 44, 45 ,46, 47, 48, 49, 50 ,51, 52, 53, 54, 55 ,56, 57, 58, 59, 60 ,61, 62, 63, 64, 65 ,66, 67, 68, 69, 70 ,71, 72, 73, 74, 75 ,76, 77, 78, 79, 80 ,81, 82, 83, 84, 85 ,86, 87, 88, 89, 90 ,91, 92, 93, 94, 95 ,96, 97, 98, 99, 100 };

Console.WriteLine("Números pares utilizando for:");
for (int i = 0; i < numeros.Count; i++)
{
    if(numeros[i]%2==0){
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("\nNúmeros pares utilizando foreach:");
foreach (int numero in numeros)
{
    if(numero%2==0){
        Console.WriteLine(numero);
    }
}

*/
/*
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};


void CalcularMediaDeVendas(string nomeDoCarro)
{
    if (vendasCarros.ContainsKey(nomeDoCarro))
    {
        List<int> vendas = vendasCarros[nomeDoCarro];
        double media = vendas.Average();
        Console.WriteLine($"A média de vendas do {nomeDoCarro} é: {media}");
    }
    else
    {
        Console.WriteLine($"O carro {nomeDoCarro} não foi encontrado na lista.");
    }
}   

CalcularMediaDeVendas("Lamborghini Aventador");
CalcularMediaDeVendas("Ferrari LaFerrari");*/