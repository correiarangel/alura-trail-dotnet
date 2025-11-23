Console.WriteLine("\n*** Criando reservas de experiênciass ***\n");

List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial(1, "Passeio de balão", "Fazenda Boa Vista"),
    new ReservaOnline(2, "Curso de C#", "https://alura.com.br/curso-online-csharp"),
    new ReservaPresencial(3, "Mergulho", "Praia do Forte"),
    new ReservaOnline(4, "Curso de Java", "https://alura.com.br/curso-online-java"),
    new ReservaPresencial(5, "Trilha Ecológica", "Parque Nacional"),
    new ReservaOnline(6, "Curso de Python", "https://alura.com.br/curso-online-python"),
    new ReservaPresencial(7, "Visita ao Museu", "Museu Histórico"),
    new ReservaOnline(8, "Curso de JavaScript", "https://alura.com.br/curso-online-javascript"),
    new ReservaPresencial(9, "Safari Fotográfico", "Reserva Natural"),
    new ReservaOnline(10,"Workshop de Culinária Italiana","https://alura.com.br/workshop-culinaria-italiana")
};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}