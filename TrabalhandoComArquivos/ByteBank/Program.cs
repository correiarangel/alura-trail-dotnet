// See https://aka.ms/new-console-template for more information

using ByteBank.Domain.Models;

Console.Clear();

Console.WriteLine("\nCarregando arquivo Byte Bank aguarde ........\n");

var path = "/home/rangel/git-dev/alura-trail-dotnet/TrabalhandoComArquivos/ByteBank/fileData/";
//var path = "/ByteBank/fileData/";

var arquivo = new Arquivo("dbByteBank.txt", path + "dbByteBank.txt", "Contas do ByteBank");
var _arquivo = new Arquivo("_dbByteBank.txt", path + "_dbByteBank.txt", "Contas do ByteBank");
//arquivo.LerArquivoStreamReader();

//_arquivo.CriarArquivo();

//arquivo.LerArquivoStreamReader();

//_arquivo.BinaryForRead();

//_arquivo.BinaryForWrite();




_arquivo.ReadFile();

Console.WriteLine("\nincia em segundos ........\n");


Task.Delay(1000).Wait();


Console.WriteLine("\nByte Bank iniciado com Sucesso!............\n");

Console.WriteLine("\nSeje Bem Vindo ao Byte Bank ;)\n");


/*
var conta = new ContaCorrente(1000, 12345, 001, "João Silva");

conta.ExibirSaldo();

conta.ExibirSaldo();
*/

Console.ReadLine();

/*var btnCancelar = new Botao("Cancelar", CoresBotao.Azul);
//btnCancelar.Cor =  (CoresBotao)3;
Console.WriteLine($"Botão: {btnCancelar.Texto} - Cor: {btnCancelar.Cor}");*/