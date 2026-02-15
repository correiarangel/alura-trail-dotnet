// See https://aka.ms/new-console-template for more information
using OperacoesEmCoolecoes.Models;

Console.WriteLine("\n\nOperações em Coleções!\n");



var musica1 = new Music("Que Pais é Esse?", "Legião Urbana", 350);
var musica2 = new Music("Tempo Perdido", "Legião Urbana", 455);
var musica3 = new Music("Pro Dia Nascer Feliz", "Barão Vermelho", 345);
var musica4 = new Music("Eduardo e Mônica", "Legião Urbana", 530);
var musica5 = new Music("Geração Coca-Cola", "Legião Urbana", 350);
var music6 = new Music("Felsz Anivesario", "Ira", 250);
var music7 = new Music("Dias de Luta", "Ira", 550);

var legiaoUrbada = new Playlist("Legião as mais tocadas");

legiaoUrbada.Add(musica1);
legiaoUrbada.Add(musica2);
legiaoUrbada.Add(musica4);
legiaoUrbada.Add(musica5);

//legiaoUrbada.DisplayPlaylist(legiaoUrbada);

var rockNacional = new Playlist("Rock Nacional");

rockNacional.Add(musica1);
rockNacional.Add(musica2);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);
rockNacional.Add(music6);
rockNacional.Add(music7);
//rockNacional.Add(new Music("Felsz Anivesario", "Ira", 250));

//rockNacional.DisplayPlaylist(rockNacional);

//Playlist.DisplayMostPlayed(legiaoUrbada, rockNacional);


var player = new PlayMusic();
player.AddQueue(music6);
player.AddQueue(rockNacional);

PlayMusic.DisplayQueue(player);

player.DisplayHistory(player);

//rockNacional.DisplayPlaylist(rockNacional);
Console.WriteLine("\n\n");

var nextMusic = player.NextSongInQueue();
if (nextMusic is not null)
{
    NextMusic(nextMusic);
}
else
{
    Console.WriteLine("Fila de reprodução vazia!");
}

PlayMusic.DisplayQueue(player);

player.DisplayHistory(player);

var previousMusic = player.PreviousMusic(player);
if (previousMusic is not null)
{
    Console.WriteLine($"\nTocando a musica {previousMusic.Title}...\n");
}
else
{
    Console.WriteLine("Fila historico de reprodução vazia!");
}
player.DisplayHistory(player);
//RemoveMusic("Pro Dia Nascer Feliz");

//rockNacional.OderByDuration();

//rockNacional.DisplayPlaylist(rockNacional);


void NextMusic(Music music)
{
    if (music is not null)
    {
        Console.WriteLine($"\nTocando a musica {music.Title}...\n");
    }
    else
    {
        Console.WriteLine("Fila de reprodução vazia!");
    }
}

void RemoveMusic(string musicTitle)
{
    var music = rockNacional.FindForTitle(musicTitle);
    if (music is not null)
    {
        Console.WriteLine("\nRemovendo música...");
        rockNacional.Remove(music);
    }
    else
    {
        Console.WriteLine("\nMúsica não encontrada!");
    }
}