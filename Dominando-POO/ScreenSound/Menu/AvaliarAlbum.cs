using ScreenSound.Menu;
using ScreenSound.Models;

internal class AvaliarAlbum : Menu
{
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        
        ExibirTituloDaOpcao("Avaliar um album");
        
        Console.Write("Digite o nome do banda que deseja avaliar: ");
        
    
        
        string nomeDobanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDobanda))
        {
            Banda banda = bandasRegistradas[nomeDobanda];

            Console.Write("Digite o título do álbum:");
            string tituloAlbum = Console.ReadLine()!;  

            banda.AdicionarAlbum(new Album(tituloAlbum));
            
            Console.Write($"Qual a nota o album {tituloAlbum} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);

            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o album {tituloAlbum}");
            Thread.Sleep(2000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nO album {nomeDobanda} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }

    }
}