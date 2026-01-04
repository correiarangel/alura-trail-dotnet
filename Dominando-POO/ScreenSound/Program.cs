using System.ComponentModel.DataAnnotations;
using ScreenSound.Menu;
using ScreenSound.Models;

Banda zeRamalo = new Banda("Zé Ramalho!");
zeRamalo.AdicionarNota(new Avaliacao(10));
zeRamalo.AdicionarNota(new Avaliacao(8));
zeRamalo.AdicionarNota(new Avaliacao(6));
Banda belChior = new("Belchior");
belChior.AdicionarNota(new Avaliacao(9));
belChior.AdicionarNota(new Avaliacao(9));
belChior.AdicionarNota(new Avaliacao(8));
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(zeRamalo.Nome, zeRamalo);
bandasRegistradas.Add(belChior.Nome, belChior);


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new RegistrarBanda());
opcoes.Add(2, new RegistrarAlbum());
opcoes.Add(3, new MostrarBandasRegistradas());
opcoes.Add(4, new ExibirDetalhe());
opcoes.Add(5, new AvaliarUmaBanda());
opcoes.Add(6, new AvaliarAlbum());
opcoes.Add(-1, new Sair()); 


void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 5 para avaliar uma banda");
    Console.WriteLine("Digite 6 para avaliar um álbum");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    if (string.IsNullOrEmpty(opcaoEscolhida))
    {
        Console.Write("\nDigite a sua opção correta o animal!!!!\n ");
        ExibirOpcoesDoMenu();
        return;
    }

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
      var menu = opcoes[opcaoEscolhidaNumerica];
      menu.Executar(bandasRegistradas);
      
      if(opcaoEscolhidaNumerica > 0 ) ExibirOpcoesDoMenu();
      
    }else{
        Console.WriteLine("Opção inválida");
    }

}

ExibirOpcoesDoMenu();