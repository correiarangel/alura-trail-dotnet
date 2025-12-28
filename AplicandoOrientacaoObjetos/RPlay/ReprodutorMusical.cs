class ReprodutorMusical
{
    public void Reproduzir(Musica musica)
    {
        Console.WriteLine($"Reproduzindo a música: {musica.Nome} do artista {musica.Artista.Nome}");
    }
    public void Pausar()
    {
        Console.WriteLine("Música pausada.");
    }
    public void Avancar()
    {
        Console.WriteLine("Avançando para a próxima música.");
    }
    public void Retroceder()
    {
        Console.WriteLine("Retrocedendo para a música anterior.");
    }
    public void AjustarVolume(int nivel)
    {
        Console.WriteLine($"Ajustando o volume para o nível: {nivel}");
    }

}




//: Responsável por controlar a reprodução de músicas, incluindo reprodução, pausa, avanço, retrocesso, controle de volume, etc.