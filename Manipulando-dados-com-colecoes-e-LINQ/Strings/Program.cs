using Strings.Domain.Models;

const string path = "/home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/Strings/Data/musicas.csv";

Console.WriteLine("\nString e Fonte de dados\n");


var file = new FileCuston();

var streen = file.NewFile(path, FileMode.Open, FileAccess.Read);

MusicExtention.GetAndDiplayTable(streen);

//streen.Close();
//ComparationString();

// var musics = MusicExtention.GetMusics(streen).Take(50);

//MusicExtention.Display([music?.Title??"SEM NOME"]);
//GetAndListSongs();

void ComparationString()
{
    // métodos que utilizam StringComparisonCo

    Console.WriteLine("\nColdplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("\nColdplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("\nColdplay".EndsWith("coldplay", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("\nColdplay".IndexOf("coldplay", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("\nColdplay".Contains("OLD", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("\nColdplay".Replace("cold", "warm", StringComparison.OrdinalIgnoreCase));

    var artist1 = "Coldplay";
    var artist2 = "Coldplay";
    Console.WriteLine($"artist1 == artist2 -> {artist1 == artist2}");
    Console.WriteLine($"ReferenceEquals(artist1, artist2) -> {ReferenceEquals(artist1, artist2)}");
    var artist3 = new string("Coldplay");
    Console.WriteLine($"ReferenceEquals(artist1, artist3) -> {ReferenceEquals(artist1, artist3)}");

    var artist4 = "COLDPLAY";
    var artist5 = artist1.ToUpper();
    Console.WriteLine($"ReferenceEquals(artist1, artist4) -> {ReferenceEquals(artist1, artist4)}");
    var artist6 = string.Intern(artist1.ToUpper());
    Console.WriteLine($"ReferenceEquals(artist4, artist5) -> {ReferenceEquals(artist4, artist5)}");
}

