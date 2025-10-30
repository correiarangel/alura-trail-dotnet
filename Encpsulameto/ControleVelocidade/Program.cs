Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtulizarVelocidade(50.5);

Console.WriteLine($"Veiculo...");
Console.WriteLine($"Placa: {veiculo.Placa}");
Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual()} km/h");
Console.WriteLine($"Aceleranso...");
veiculo.AtulizarVelocidade(80.5);
Console.WriteLine($"Velocidade: {veiculo.VelocidadeAtual()} km/h");
