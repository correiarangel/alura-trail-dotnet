using Linq.Domain.Models;


Console.WriteLine("\nAbstraido Fonte de dados\n");

const string path = "/home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/AbstraindoFonteDeDados/Data/musicas.csv";

var file = new FileCuston();

var streen = file.NewFile(path, FileMode.Open, FileAccess.Read);

  //var musics = MusicExtention.GetMusics(streen)
  //  .Where(music => music.Artist.StartsWith("Rolling Stones"))
  //  .OrderBy(mu => mu.Title);
  
  //var musics = MusicExtention.GetMusics(streen)
  //  .Where(music => music.Artist.StartsWith("Rolling Stones"))
  //  .OrderByDescending(mu => mu.Title)
  //  .ThenBy(m=> m.Duration)
  //  .Take(3);//Use p/  paginação !

  //var musics = MusicExtention.GetMusics(streen)
  //  .Where(music => music.Artist.StartsWith("Rolling Stones"))
  //  .OrderByDescending(mu => mu.Title)
  //  .ThenBy(m=> m.Duration)
  //  .Skip(4); //Use p/  paginação !


  //var musics = MusicExtention.GetMusics(streen)
  //  .Where(music => music.Artist.StartsWith("Rolling Stones"))
  //  .OrderByDescending(mu => mu.Title)
  //  .ThenBy(m=> m.Duration)
  //  .Skip(5*1) // cada pagina 5 elemetos para pular para pag 1 -> (5),pag 2 -> (5 x 1) pag 3 -> (5 x 2) ,
  //  .Take(5); 

 //MusicExtention.MusicStatistics(streen);

//MusicExtention.ExistenceVerificationOperations(streen);
 MusicExtention.ExistenceVerificationOperations(streen,"Reggae");
 
 //MusicExtention.OperationsForObtainingElements(streen);

//var artists = MusicExtention.FillOrderByGenders(streen);
//MusicExtention.Display(artists);

streen.Close();


