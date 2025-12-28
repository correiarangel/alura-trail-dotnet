class DownloadManager
{
    private List<Musica> downloadsEmAndamento = new List<Musica>();

    public void IniciarDownload(Musica musica)
    {
        downloadsEmAndamento.Add(musica);
        Console.WriteLine($"Iniciando download de '{musica.Nome}'...");
        // Simulação de download
        System.Threading.Thread.Sleep(2000); // Simula o tempo de download
        downloadsEmAndamento.Remove(musica);
        Console.WriteLine($"Download de '{musica.Nome}' concluído!");
    }

    public List<Musica> ObterDownloadsEmAndamento()
    {
        return downloadsEmAndamento;
    }         
}

// Responsável por gerenciar o download de músicas ou álbuns para uso offline.