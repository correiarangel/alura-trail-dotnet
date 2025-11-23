Console.WriteLine("\n*** Criando avaliação de conteúdos em uma plataforma ***\n");


List<Conteudo> conteudos = new List<Conteudo>
{
    new AulaGravada("Introdução ao C#", 45),
    new MaterialComplementar("Guia de Referência C#", "PDF"),
    new AulaGravada("Programação Orientada a Objetos", 60),
    new MaterialComplementar("Exemplos de Código", "ZIP")
};

Console.WriteLine("Exibindo informações dos conteúdos:\n");

foreach (var conteudo in conteudos)
{
    conteudo.ExibirInfo();
}

Console.WriteLine("\n*** Fim da avaliação de conteúdos ***\n");


