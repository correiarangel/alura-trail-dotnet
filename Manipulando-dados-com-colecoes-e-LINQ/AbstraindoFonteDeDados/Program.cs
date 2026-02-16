using AbstraindoFonteDeDados.Domain.Models;

Console.WriteLine("\nAbstraido Fonte de dados\n");


///home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/AbstraindoFonteDeDados/Data/
const string path = "/home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/AbstraindoFonteDeDados/Data/musicas.csv";

var file = new FileCuston();

var streen = file.NewFile(path, FileMode.Open, FileAccess.Read);
//music.Title.StartsWith("A")
//var musics = Music.GetMusics(streen)
//    .FilterBy(MusicExtention.FillterMusicByCondeplay)
//    .FilterBy(MusicExtention.FillterMusicDurationLoong);

//var musics = Music.GetMusics(streen)
//    .FilterBy(music => music.Artist.StartsWith("Rolling Stones"))
//    .FilterBy(mu => mu.Title.StartsWith("S"))
//    .FilterBy(m =>m.Duration >= 300);

  var musics = Music.GetMusics(streen)
    .Where(music => music.Artist.StartsWith("Rolling Stones"))
    .Where(mu => mu.Title.StartsWith("S"))
    .Where(m =>m.Duration >= 300);
  


//Music.DisplayMusics(musicas);
///var musicsFilter = MusicExtention.FillterMusicByName(musicas,"Coldplay");
//var musicsFilter = MusicExtention.FilterBy(musicas, MusicExtention.FillterMusicByCondeplay);


MusicExtention.DisplayMusics(musics);
