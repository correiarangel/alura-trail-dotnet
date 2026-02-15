class MyFile
{

    /**
    O yield pode parecer um detalhe de sintaxe, mas na prática ele resolve problemas bem comuns: como lidar com coleções grandes, fluxos de dados e processamento sob demanda.

    Pense no yield como um podcast de episódios semanais. Você não precisa esperar que toda a temporada seja gravada para começar a ouvir. Os episódios vão sendo liberados um por um, e você consome apenas o que já foi publicado.

    Exemplo 1: Leitura de linhas em um arquivo grande
    Imagine que você precise processar um arquivo de 1 milhão de linhas.
     Se você carregar tudo na memória de uma vez, sua aplicação pode travar. Com yield, você lê uma linha por vez:
    */
    
    static IEnumerable<string> LerArquivo(string caminho)
    {
        using var reader = new StreamReader(caminho);

        string? linha;
        while ((linha = reader.ReadLine()) != null)
        {
            yield return linha;
        }
    }

    public void ReadFile()
    {
        foreach (var linha in LerArquivo("dados.txt"))
        {
            Console.WriteLine(linha);
        }
    }

    /*
    ➡️ Aqui, você pode começar a processar o arquivo imediatamente, sem esperar que todo ele seja carregado.

    Exemplo 2: Paginação de dados em banco
    Suponha que você tenha que buscar registros em lotes (páginas) de 1000 em 1000, em vez de tudo de uma vez.
    */
    static IEnumerable<List<T>> BuscarEmPaginas<T>(Func<int, List<T>> buscarPagina)
    {
        int pagina = 0;
        while (true)
        {
            var resultados = buscarPagina(pagina);
            if (resultados.Count == 0)
                yield break; // acabou

            yield return resultados;
            pagina++;
        }
    }

    public void ConsumirBusca()
    {
        foreach (var lote in BuscarEmPaginas(p => BuscarUsuarios(p)))
        {
            Console.WriteLine($"Processando {lote.Count} usuários...");
        }
    }

    private List<object> BuscarUsuarios(int p)
    {
        throw new NotImplementedException();
    }

    /*
    ➡️ Assim você processa página por página, evitando sobrecarregar a aplicação com todos os registros de uma vez.

    Exemplo 3: Geração de relatórios
    Em vez de gerar todos os dados de um relatório antes de exibir, você pode ir liberando seções conforme são processadas:

    */
    static IEnumerable<string> GerarRelatorio()
    {
        yield return "Início do relatório";
        yield return "Seção 1: Dados gerais";
        yield return "Seção 2: Estatísticas";
        yield return "Seção 3: Conclusões";
        yield return "Fim do relatório";
    }

    public void ExibeRelatorio()
    {
        foreach (var parte in GerarRelatorio())
        {
            Console.WriteLine(parte);
        }
    }

    /*
    ➡️ Isso permite exibir resultados progressivamente, em vez de travar a aplicação até que tudo esteja pronto.

    Exemplo 4: Algoritmos complexos
    No desenvolvimento de jogos ou simulações, o yield pode produzir os próximos passos de forma incremental.

    */
    static IEnumerable<string> SimularPartida()
    {
        yield return "Jogador 1 fez a jogada";
        yield return "Jogador 2 contra-atacou";
        yield return "Jogador 1 venceu a rodada";
    }

}



/***

Em resumo
O yield é ideal quando:

os dados são grandes (arquivos, coleções do banco de dados, logs);
você quer processar sob demanda sem carregar tudo de uma vez;
deseja produzir fluxos contínuos ou parciais (como logs em tempo real, relatórios incrementais, simulações).
O yield é como uma esteira de produção: você não espera o produto inteiro ser fabricado para começar a usá-lo, ele sai em partes.

*/