class Veiculo(string placa)
{

    public string Placa { get; set; } = placa;
    private double Velocidade   { get; set; }
    public void AtulizarVelocidade(double novaVelocidade)
    {
        Velocidade = novaVelocidade;
    }
    
    public double VelocidadeAtual()
    {
       return Velocidade;
    }

}