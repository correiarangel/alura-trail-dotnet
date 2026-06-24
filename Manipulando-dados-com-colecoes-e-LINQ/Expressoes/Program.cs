using Exceptions.Domain.Models;

const string path = "/home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/Expressoes/Data/musicas.csv";

Console.WriteLine("\nString e Fonte de dados\n");


var file = new FileCuston();

var streen = file.NewFile(path, FileMode.Open, FileAccess.Read);

MusicExtention.GetArtistRegex(streen);



