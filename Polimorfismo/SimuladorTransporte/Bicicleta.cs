class Bicicleta : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm * 4;
    }
}