class LetraMusica
{
    public string Texto { get; set; }
    public Musica Musica { get; set; }

    public void ExibirLetra()
    {
        Console.WriteLine($"Letra da música {Musica.Nome}:");
        Console.WriteLine(Texto);
    }

    public List<int> BuscarPalavra(string palavra)
    {
        List<int> linhasComPalavra = new List<int>();
        var linhas = Texto.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < linhas.Length; i++)
        {
            if (linhas[i].IndexOf(palavra, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                linhasComPalavra.Add(i + 1); // +1 para ajustar ao número da linha
            }
        }
        return linhasComPalavra;
    }
}

    
//Representa a letra de uma música, permitindo a exibição ou busca de letras.