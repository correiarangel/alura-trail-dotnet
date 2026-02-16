# LINQ — Operações e Exemplos

Operações do LINQ se enquadram em categorias de acordo com sua função. Trabalhamos com manipulação de coleções através de um fluxo padrão: **Estágio 1 (Origem Dados) > Estágio 2 > ... > Estágio N**.

## Categorias de Operações do LINQ

| Categoria | Descrição | Métodos | Avaliação |
|-----------|-----------|---------|-----------|
| **Filtro** | Coleção com tamanho menor/igual, atendendo condição | `Where`, `Distinct` | Sob demanda (+) |
| **Projeção** | Coleção transformada, do mesmo tipo ou não | `Select`, `SelectMany` | Sob demanda (+) |
| **Ordenação** | Coleção ordenada pela expressão lambda | `OrderBy`, `ThenBy`, `ThenByDescending` | Sob demanda (+) |
| **Agregação** | Valor único a partir de operação de acúmulo | `Sum`, `Min`, `Max`, `Count`, `Average` | Imediata (*) |
| **Agrupamento** | Coleção de grupos onde a chave é o argumento | `GroupBy` | Sob demanda (+) |
| **Elementos** | Elemento único T a partir do argumento | `First`, `Last`, `MinBy`, `MaxBy`, `FirstOrDefault`, `LastOrDefault` | Imediata (*) |
| **Existência** | Booleano a partir da operação e argumento | `All`, `Any`, `Contains` | Imediata (*) |
| **Conversão** | Coleção em outra estrutura | `ToList`, `ToArray`, `ToHashSet`, `ToDictionary` | Imediata (*) |

**Legenda:** `+` operações avaliadas sob demanda (lazy evaluation); `*` operações avaliadas imediatamente.

## Exemplos Práticos

### Filtro e Ordenação

```csharp
void OperacoesDeFiltroEOrdenacao(StreamReader stream)
{
    var musicasDoColdplay = ObterMusicas(stream)
        .Where(musica => musica.Artista == "Coldplay") // filtragem por artista
        .OrderBy(musica => musica.Titulo)
        .Skip(5 * 2)
        .Take(5);

    ExibirMusicas(musicasDoColdplay);
}
```

### Projeção e Seleção de Artistas

Obtém apenas os artistas (sem duplicatas) em ordem alfabética:

```csharp
var artistas = ObterMusicas(stream)
    .Select(m => m.Artista)
    .Distinct()
    .OrderBy(a => a);

foreach (var artista in artistas)
{
    Console.WriteLine(artista);
}
```

### SelectMany para Coleções Aninhadas

Quando uma propriedade é uma coleção (ex.: gêneros), use `SelectMany` para achatar:

```csharp
public IEnumerable<string> Generos { get; set; }

// Ao construir o modelo a partir das partes da linha CSV:
Generos = partes[3].Split(',').Select(g => g.Trim());
```

Obtém todos os gêneros distintos do arquivo:

```csharp
var generos = ObterMusicas(stream)
    .SelectMany(m => m.Generos)      // achata coleção de gêneros
    .Distinct()                       // remove duplicatas
    .OrderBy(g => g);                 // ordena alfabeticamente

foreach (var genero in generos)
{
    Console.WriteLine(genero);
}
```

### Ordenação em Múltiplos Níveis

Aplique critérios hierárquicos com `OrderBy`, `ThenBy` e `ThenByDescending`:

```csharp
var playlistOrdenada = musicas
    .OrderBy(m => m.Artista)
    .ThenBy(m => m.Nome)
    .ThenByDescending(m => m.Duracao);
```

Aqui, a coleção é ordenada primeiramente pelo artista; em caso de igualdade, pelo nome da música; e finalmente pela duração em ordem decrescente.

### Agrupamento de Dados

Agrupa músicas por artista e extrai informações relevantes:

```csharp
var musicasPorArtista = musicas
    .GroupBy(m => m.Artista)
    .Select(g => new 
    { 
        Artista = g.Key, 
        Total = g.Count(),
        DuracaoMedia = g.Average(m => m.Duracao)
    });
```

## Considerações de Otimização

### Avaliação sob Demanda vs. Imediata

Operações como `Where` e `Select` são avaliadas sob demanda (lazy evaluation) — só processam dados quando realmente necessário. Operações como `Count()`, `Sum()` e `ToList()` são avaliadas imediatamente, forçando o processamento completo da coleção.

**Quando materializar em memória:**
- Se a origem de dados for um recurso custoso (arquivo, banco de dados), materialize com `ToList()` ou `ToArray()` uma única vez.
- Cuidado: se a coleção for muito grande, pode impactar memória.

**Exemplo de problema:**
```csharp
var musicas = ObterMusicas(stream);
Console.WriteLine(musicas.Count(m => m.Duration >= 300)); // 1ª leitura
Console.WriteLine(musicas.Count());                       // 2ª leitura (stream já exaurido!)
```

**Solução:**
```csharp
var musicas = ObterMusicas(stream).ToList(); // Materializa uma única vez
Console.WriteLine(musicas.Count(m => m.Duration >= 300));
Console.WriteLine(musicas.Count());
```

## Resumo das Boas Práticas

1. **Entenda lazy evaluation:** Filtros e projeções não processam dados até consumo.
2. **Materialize quando apropriado:** Use `ToList()` para evitar re-enumeração.
3. **Combine operações eficientemente:** Encadeie operações para criar pipelines claros.
4. **Use a categoria correta:** Escolha `GroupBy` para agregações por chave, não loops manuais.
5. **Considere performance:** Em coleções grandes, cada operação adicional tem custo.

O LINQ oferece uma sintaxe declarativa e intuitiva para manipular coleções, facilitando manutenção e legibilidade do código.
