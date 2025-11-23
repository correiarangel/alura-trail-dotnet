class Onibus : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return (distanciaKm * 2) + 5;
    }
}