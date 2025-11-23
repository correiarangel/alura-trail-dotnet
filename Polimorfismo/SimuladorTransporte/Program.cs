Console.WriteLine("\n*** Criando simulador de transporte urbano ***\n");


List<Transporte> transportes = new List<Transporte>()
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};

int distancia = 1000; // Distância em km


Console.WriteLine($"Distância a ser percorrida: {distancia} km\n");

foreach (var transporte in transportes)
{
  Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");;
}

Console.WriteLine("\n*** Fim do simulador de transporte urbano ***");