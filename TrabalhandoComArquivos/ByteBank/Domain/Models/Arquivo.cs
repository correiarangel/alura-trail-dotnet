using System.Text;

namespace ByteBank.Domain.Models;

public class Arquivo(string nome, string pathArq, string content)
{
    private string _Nome { get; set; } = nome;
    private string _PathArq { get; } = pathArq;
    private string _Content { get; } = content;
    private int _NumeroByteLidos { get; set; } = -1;
    private byte[] _Buffer { get; set; } = new byte[1024];//1KB

    public void LerArquivo()
    {

        using (var _FluxoArquivo = new FileStream(_PathArq, FileMode.Open))
        {
            while (_NumeroByteLidos != 0)
            {

                _FluxoArquivo?.Read(_Buffer, 0, 1024);
                EscreverBuffer();
                _NumeroByteLidos = _FluxoArquivo != null ? _FluxoArquivo.Read(_Buffer, 0, 1024) : 0;
            }
            _FluxoArquivo.Close();
        }


    }

    public void LerArquivoStreamReader()
    {

        using (var fluxoDeArquivo = new FileStream(_PathArq, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            //var linha = leitor.ReadLine();
            //var texto = leitor.ReadToEnd()
            //var numero = leitor.Read();
            var arquivo = new Arquivo("dbByteBank.txt", _PathArq, "Contas do ByteBank");
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine() ?? "";
                //Console.WriteLine(linha);
                ConvertStringToContaCorrente(linha);
            }
            fluxoDeArquivo.Close();
        }

    }


    public void EscreverBuffer()
    {
        Console.WriteLine("\nIncio do Arquivo byte a byte\n");
        foreach (var _byte in _Buffer)
        {
            Console.Write(_byte);
            Console.Write(" ");
        }
        Console.WriteLine("\nFim do Arquivo byte a byte\n");
    }

    public void ConvetBuffer()
    {
        Console.WriteLine("\nIncio do Arquivo byte a byte\n");
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(_Buffer);
        Console.WriteLine(texto);
        Console.WriteLine("\nFim do Arquivo byte a byte\n");
    }

    public void CriarArquivo()
    {
        Console.WriteLine("\nIncio criação de Arquivo txt\n");
        using (var fluxoDeArquivo = new FileStream(_PathArq, FileMode.Create))
        {
            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(_Content);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
        Console.WriteLine("\n Arquivo  Criação Comm sucesso!\n");
    }
    public void ConvertStringToContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agencia = campos[0];
        var numeroConta = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var titularNome = campos[3];

        var titular = new Cliente(titularNome);

        int agenciaInt = int.Parse(agencia);
        int numeroContaInt = int.Parse(numeroConta);
        decimal saldoDecimal = decimal.Parse(saldo);


        var contaCorrente = new ContaCorrente(saldoDecimal, numeroContaInt, agenciaInt, titular.TitularNome);
        contaCorrente.ExibirSaldo();
    }

    public void TesteTimeForWrite()
    {
        var path = $"{_PathArq}";

        using (var fluxoDeArquivo = new FileStream(path, FileMode.Create))
        using (var write = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 9999; i++)
            {
                write.WriteLine($"Line: {i}");
                write.Flush();
                Console.WriteLine($"Line: {i} Maecos Rangel Você vai ser um escelente programador C#");

            }
            Console.WriteLine($"Escrita completa!");
        }
    }

    public void BinaryForRead()
    {
        using (var fs = new FileStream(_PathArq, FileMode.Create))
        using (var write = new BinaryWriter(fs))
        {
            write.Write(3256);
            write.Write(234365);
            write.Write(4000.50);
            write.Write("Dick Vigarista");

            Console.WriteLine($"Escrita completa!");
        }
    }

    public void BinaryForWrite()
    {
        using (var fs = new FileStream(_PathArq, FileMode.Open))
        using (var write = new BinaryReader(fs))
        {
            var agencia = write.ReadInt32();
            var numeroConta = write.ReadInt32();
            var saldo = write.ReadDouble();
            var titular = write.ReadString();

            Console.WriteLine($"Agencia: {agencia}");
            Console.WriteLine($"Numero Conta: {numeroConta}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Titular: {titular}");
        }
    }

    public void InputBinaryForRead()
    {
        using (var fs = Console.OpenStandardInput())
        using (var _fs = new FileStream(_PathArq, FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var byteWrite = fs.Read(buffer, 0, 1024);
                _fs.Write(buffer, 0, byteWrite);
                _fs.Flush();

                Console.WriteLine($"Byte lidos ! {buffer.Length}");
            }
        }
    }

    public void ReadFile()
    {

        var linhas = File.ReadAllLines(_PathArq);
        Console.WriteLine($"//////////////// linhas.Length: {linhas.Length}");
        /*
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }*/

        var bytesArquivo = File.ReadAllBytes(_PathArq);
        Console.WriteLine($"{_PathArq} possui {bytesArquivo.Length} bytes");
        Console.WriteLine("Fala ai ooo ...");
        var input = Console.ReadLine() ?? string.Empty;
        File.WriteAllText(_PathArq, input);

        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();

        /*
        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
        Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);
        */
    }

}
