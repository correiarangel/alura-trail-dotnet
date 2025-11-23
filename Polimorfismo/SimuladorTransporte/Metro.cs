class Metro : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm + 5;
    }
}