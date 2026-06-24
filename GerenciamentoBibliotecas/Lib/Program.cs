using Lib.Application.Service;
using Lib.Domain.Interface;
using Lib.Domain.Models;
using ReportGeneration;
using ReportGeneration.Domain.Models;
/*
const string path = "/home/rangel/git-dev/alura-trail-dotnet/Manipulando-dados-com-colecoes-e-LINQ/Serializacao/Data/musicas.csv";

Console.WriteLine("\nSerialização de dados..........\n");


var file = new FileCuston();

var streen = file.NewFile(path, FileMode.Open, FileAccess.Read);

MusicExtention.GetArtistsAndSerialize(streen);


*/

ILocalClientHttp clientHttp = new ClientHttpService();

 await(GetMusics());




async Task GetMusics()
{
    List<Dictionary<string, string>> _data = new();
    List<Music> musics = await clientHttp.GetStringAsync();
    foreach (var music in musics)
    {
        var record = new Dictionary<string, string>
            {
               { "Nome", music.Name },
                { "Artista", music.Artist },
                { "Genero", music.Genero },
                { "Tonalidade", music.Tonalidade }
            };
        _data.Add(record);

    }
  //  ReportCsv reporterGenerator = new ReportCsv(input: _data, title: "Relatório de Pessoas", headLine: "Nome,Idade,Cidade", footerLine: "Fim do relatório");

ReportPdf reporterGenerator = new ReportPdf(_data);
string local = reporterGenerator.GenerateReport();

    Console.WriteLine("O arquivo foi salvo em: " + local);
}

