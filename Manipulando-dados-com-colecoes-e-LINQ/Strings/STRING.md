# Strings em C#

## Organizando o Ambiente no Visual Studio

Antes disso, vamos organizar nosso ambiente no Visual Studio. Primeiro, fecharemos a aba que contém o arquivo `program.cs` do projeto 4, relacionado ao LINQ. Em seguida, na barra inicial do Visual Studio, selecionaremos o próximo projeto, número 5, chamado "string", que será nosso objeto de estudo. Fecharemos o projeto 4 e abriremos o projeto 5, além da classe `program.cs`, que contém o arquivo inicial de um projeto do tipo terminal. Notem que esse projeto inicial já contém o texto "Hello World", demonstrando a onipresença dos textos e a necessidade de manipulá-los em nossos programas.

```csharp
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

Vamos selecionar todo o conteúdo desse arquivo e apagá-lo, substituindo-o por um código pronto que vem do nosso estudo de coleções. Esse código, do projeto 5, é uma estrutura mais elaborada do trabalho com coleções que fizemos até aqui. Para recapitular, estamos obtendo uma coleção de músicas a partir de um arquivo CSV, usando uma operação de filtro para pegar as cinco primeiras músicas e exibi-las. A diferença neste código é que o arquivo CSV contém uma coluna adicional com a data de lançamento da música. Na linha 43, temos uma nova propriedade na classe `Musica`, que é o lançamento da música, do tipo `DateTime`. Por fim, exibimos essa data de lançamento entre colchetes.

## Implementando a Leitura de Músicas de um Arquivo CSV

```csharp
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

var musicas = ObterMusicas(stream)
    .Take(50);

ExibirMusicas(musicas);

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    Console.WriteLine("\nMúsicas do arquivo:");
    foreach (var musica in musicas)
    {
        var linha = $"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao}s [{musica.Lancamento}]";
        Console.WriteLine(linha);
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');
        var musica = new Musica
        {
            Titulo = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            Generos = partes[3].Split(',').Select(g => g.Trim()),
            Lancamento = Convert.ToDateTime(partes[4])
        };
        yield return musica;
        linha = stream.ReadLine();
    }
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
    public DateTime Lancamento { get; set; }
}
```

Vamos salvar e executar o arquivo com F5. No terminal, as cinco primeiras músicas são exibidas segundo o padrão criado: título, artista entre parênteses, um hífen com a duração em segundos e, por fim, a data de lançamento entre colchetes.

## Introduzindo o Conceito de Strings

Vamos começar nosso estudo de strings pelo mais simples. Uma string é um objeto em memória, uma classe no .NET. Quando precisamos de uma string, alocamos um objeto em memória, mas, diferentemente do padrão normal de criação de objetos, não usamos `new`. Criamos usando o **string literal**, que é escrever um texto entre aspas duplas. No método de exibição de músicas, o título é uma string e está sendo alocado como um objeto. Vamos mover esse título para uma variável para demonstrar essa alocação.

```csharp
var titulo = "\nMúsicas do arquivo:";
Console.WriteLine(titulo);
```

Ao passar o mouse sobre a variável `titulo`, vemos que é uma `string` ou nula, mas não será nula, pois estamos alocando diretamente. Essa alocação de um objeto do tipo string é chamada de **string literal**.

## Explorando Métodos de Manipulação de Strings

Podemos criar um objeto de string de outra maneira, embora não seja comum nem recomendado. Poderíamos usar `new String` e passar o texto, mas isso não é o padrão. O string literal é a maneira natural de alocar memória para objetos do tipo string.

Nos códigos anteriores, já manipulamos strings usando alguns métodos. Destacamos o método `Split`, da classe string, que recebe como argumento o separador e divide uma linha em várias partes, criando um array de strings. Outro método é o `Trim`, que remove espaços em branco do início e do fim da string. Existem variações como `TrimStart` e `TrimEnd`, que removem espaços apenas do início ou do fim, respectivamente.

```csharp
g.TrimStart();
g.TrimEnd();
```

Outro método que já utilizamos é o `StartsWith`, aplicado em uma operação de filtro na coleção de entrada. Ele verifica se o título da música começa com um determinado caractere. Usamos aspas simples para denotar um caractere único, enquanto aspas duplas são usadas para textos completos. O `StartsWith` retorna um valor booleano, verificando se a string começa com o caractere especificado.

```csharp
var musicas = ObterMusicas(stream)
    .Where(m => m.Titulo.StartsWith('T'))
    .Take(50);
```

## String como Array de Caracteres

Uma string é, na verdade, um array de caracteres. Sendo uma coleção, pode ser usada com métodos do LINQ. Podemos enumerar uma string. Por exemplo, ao criar uma string chamada `titulo`, podemos manipulá-la como uma coleção de caracteres.

```csharp
var titulo = "Músicas do arquivo";
foreach(var letra in titulo) Console.WriteLine(letra);
```

A variável `titulo` é do tipo `string` e é um enumerável de `char`. A variável `letra` é do tipo `char`. Se executarmos este código, teremos a exibição de cada letra que está na string `titulo`. Utilizamos o `Console.WriteLine`, por isso foi apresentado linha a linha. Repare que o espaço também faz parte da string e está sendo exibido.

## Validando a Força de uma Senha usando LINQ

Temos um enumerado, então podemos fazer operações de LINQ a partir de uma string. Vamos fazer um exercício sobre como usar o LINQ em uma string. Imagine que estamos trabalhando com um aplicativo de músicas, onde há um módulo específico para registro de usuários. A pessoa precisará inserir seus dados, como nome, e-mail, nome de usuário e uma senha. Essa senha, em algum momento, será transportada no nosso software. Se for um software web, ela sairá do navegador de um formulário, e isso chegará ao código em C#. Teremos uma string representando essa senha.

Queremos validar se a senha é forte. Temos algumas regras para uma senha forte, que são cinco características. Vamos fazer uma operação de agregação para cada regra, utilizando LINQ. A primeira regra é verificar o total de caracteres, que pode ser feito a partir da propriedade `Length` da própria string. Poderíamos usar também o `Count`, que é um método de agregação do LINQ.

```csharp
var senha = "123";
var totalCaracteres = senha.Length;
```

Agora, vamos obter o total de letras maiúsculas. Vamos usar uma operação de agregação com uma expressão lambda dentro do `Count` para nos dar uma condição. Para cada `char`, vamos verificar se é maiúsculo usando o método estático `Char.IsUpper`.

```csharp
var totalLetrasMaiusculas = senha.Count(c => char.IsUpper(c));
```

Da mesma forma, existe um `IsLower` para letras minúsculas, e `IsDigit` para verificar se é um número.

```csharp
var totalLetrasMinusculas = senha.Count(c => char.IsLower(c));
var totalNumeros = senha.Count(c => char.IsDigit(c));
```

Por fim, verificamos se possui algum símbolo. Consideraremos que não é uma letra nem um dígito, usando a negação `!Char.IsLetterOrDigit`.

```csharp
var totalSimbolos = senha.Count(c => !char.IsLetterOrDigit(c));
```

## Determinando a Força da Senha

Agora, precisamos apresentar uma mensagem para dizer se a senha é forte ou não. Se `totalCaracteres` for menor que 8, `totalLetrasMaiusculas` for zero, `totalLetrasMinusculas` for zero, `totalNumeros` for zero ou `totalSimbolos` for zero, qualquer uma dessas condições fará com que a senha seja considerada fraca.

```csharp
if (totalCaracteres < 8 ||
    totalLetrasMaiusculas == 0 ||
    totalLetrasMinusculas == 0 ||
    totalNumeros == 0 ||
    totalSimbolos == 0 )
{
    Console.WriteLine("A senha digitada é fraca!");
}
else
{
    Console.WriteLine("A senha digitada é forte!");
}
```

Vamos executar e, de fato, a senha digitada é fraca. Vamos colocar uma senha forte, com letra maiúscula, nome, números e símbolo:

```csharp
var senha = "Daniel123%";
```

Agora, a senha passou a ser forte, atendendo a todas as regras.

## Para Saber Mais: String como Coleção de Caracteres

### A Natureza Enumerável das Strings

No .NET, uma string é mais do que apenas uma sequência de caracteres. Ela é uma instância de uma classe **imutável** que, internamente, armazena cada caractere em uma coleção. Essa característica permite que possamos iterar sobre seus elementos individualmente, exatamente como faríamos com qualquer outro tipo que implemente a interface `IEnumerable`. Essa propriedade abre caminho para a aplicação de métodos do LINQ diretamente na string, facilitando transformações e filtragens de forma concisa.

### Iterando e Manipulando com LINQ

Uma das vantagens de considerar a string como uma coleção de caracteres é a possibilidade de utilizar o poder do LINQ para processar os dados textuais. Por exemplo, podemos aplicar o método `Count` com uma expressão lambda para verificar cada caractere, ou iterar diretamente com `foreach`:

```csharp
string texto = "Hello World";
int totalMaiusculas = texto.Count(c => char.IsUpper(c));
Console.WriteLine($"Total de letras maiúsculas: {totalMaiusculas}");

foreach (char letra in texto)
{
    Console.WriteLine(letra);
}
```

### Considerações sobre Benefícios e Cuidados

A abordagem de tratar a string como uma coleção de caracteres oferece flexibilidade, permitindo aplicar diversos métodos de consulta e transformação providos pelo LINQ. Essa característica é útil, por exemplo, na validação de padrões, contagem de tipos de caracteres e até na construção de novas strings com base em condições específicas.

No entanto, é importante lembrar que, por ser uma estrutura **imutável**, qualquer modificação que pareça alterar uma string na verdade gera uma nova instância. Assim, operações pesadas de concatenação repetida podem impactar a performance. Nessas situações, alternativas como o `StringBuilder` podem ser mais adequadas para a manipulação eficiente de grandes volumes de dados textuais.

A compreensão de que uma string se comporta como uma coleção de caracteres é crucial para explorar todo o potencial das operações com LINQ e, consequentemente, para escrever códigos mais limpos e expressivos em C#.

## Resumo da Aula

Nesta aula, aprendemos:

- Que strings são imutáveis em C# e modificações geram novas instâncias.
- A utilizar métodos como `Replace`, `ToUpper`, `StartsWith` e `EndsWith` para manipulação eficiente de strings.
- A importância do string pool e interning para reutilização de referências de strings literais.
- Como a imutabilidade de strings impacta a performance e garante segurança no processamento paralelo.
- A formatar strings e valores usando interpolação, `PadLeft`, `PadRight` e `string.Format`.
- A validar e converter strings com `int.TryParse` e `string.IsNullOrWhiteSpace`.
- A comparar strings considerando maiúsculas e minúsculas com `StringComparison.OrdinalIgnoreCase`.
- A encapsular funcionalidades em métodos dedicados para organização e clareza do código.
