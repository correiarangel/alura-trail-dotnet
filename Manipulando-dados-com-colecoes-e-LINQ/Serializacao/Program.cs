using Serializacao.Domain.Models;

const string path = "/home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/Serializacao/Data/musicas.csv";

Console.WriteLine("\nSerialização de dados..........\n");


var file = new FileCuston();

var streen = file.NewFile(path, FileMode.Open, FileAccess.Read);

MusicExtention.GetArtistsAndSerialize(streen);



