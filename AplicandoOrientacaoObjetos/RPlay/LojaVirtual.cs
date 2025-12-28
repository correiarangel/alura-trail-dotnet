class LojaVirtual
{
    public void ComprarMusica(Musica musica)
    {
        Console.WriteLine($"Música comprada: {musica.Nome} por {musica.Artista.Nome}");
    }
    public void BaixarMusica(Musica musica)
    {
        Console.WriteLine($"Música baixada: {musica.Nome} por {musica.Artista.Nome}");
    }
    
}

//Representa uma loja virtual de músicas, permitindo a compra ou download de músicas ou álbuns.
