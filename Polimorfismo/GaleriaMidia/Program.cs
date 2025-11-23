Console.WriteLine("\n*** Criando Galeria de mídias ***\n");

List<Midia> galerias = new List<Midia>()
{
    new Video("Aula de C#", 300),
    new Video("Documentário DotNET.mp4", 1200),
    new Video("Aula de Daet.mp4", 300),
    new Video("Documentário Flutter.mp4", 1200),
    new Imagem("Foto de Praia.png", "1920x1080"),
    new Imagem("Montanha ao pôr do sol.png", "2560x1440")
};

Console.WriteLine("\n-------------------------[ Incio Mídias ]-------------------------\n");
foreach (var midia in galerias)
{
    midia.ExibirDetalhes();
}
Console.WriteLine("\n-------------------------[ Fim Mídias ]-------------------------\n");