// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("\n R Play .....\n");
/*
Console.WriteLine("\n Banda 1...\n");

var queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica("Love of my life", queen)
{
    Disponivel = false,
    Duracao = 231
};

Musica musica2 = new Musica("Bohemian Rhapsody", queen)
{
    Disponivel = true,  
    Duracao = 354
};


albumDoQueen.AdicionarMusica(musica1);
musica1. ExibirFichaTecnica();

albumDoQueen.AdicionarMusica(musica2);
musica2. ExibirFichaTecnica();

albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);

queen.ExibirDicografia();


Console.WriteLine("\n Banda 2...\n");

Banda nirvana = new Banda("Nirvana");

Album albumDoNirvana = new Album("In Utero");

Musica musica1N = new Musica("Heart Shaped Box", nirvana)
{
    Disponivel = true,
    Duracao = 431
};

Musica musica2N = new Musica("Rape Me", nirvana)
{
    Disponivel = true,  
    Duracao = 323
};

Musica musica3N = new Musica("Very Ape", nirvana)
{
    Disponivel = true,  
    Duracao = 323
};

albumDoNirvana.AdicionarMusica(musica1N);
musica1N. ExibirFichaTecnica();

albumDoNirvana.AdicionarMusica(musica2N);
musica2N. ExibirFichaTecnica();

albumDoNirvana.AdicionarMusica(musica3N);
musica3N. ExibirFichaTecnica();

albumDoNirvana.ExibirMusicasDoAlbum();

nirvana.AdicionarAlbum(albumDoNirvana);

nirvana.ExibirDicografia();

albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);

queen.ExibirDicografia();

*/

Console.WriteLine("\n Convidado para Podcast .....\n");

var episosiodo1 = new Episodio(1, "O Início do RPlay", 60);
episosiodo1.AdicionarConvidado("João da Silva");
episosiodo1.AdicionarConvidado("Maria Oliveira");
Console.WriteLine(episosiodo1.Resumo);

var episosiodo2 = new Episodio(2, "Se look", 60);
episosiodo2.AdicionarConvidado("Juca Pirama ");
episosiodo2.AdicionarConvidado("Sása Mutema");
Console.WriteLine(episosiodo2.Resumo);

Console.WriteLine("\n");
var podcastRPlay = new Podcast("R Play", "Ana Souza", new DateTime(2024, 1, 15));
podcastRPlay.AdicionarEpisodio(episosiodo1);
podcastRPlay.AdicionarEpisodio(episosiodo2);
podcastRPlay.ExibirEpisodios();
Console.WriteLine("\n");
