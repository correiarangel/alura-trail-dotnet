using DispositivosSensores;

class SensorTemperatura : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de Temperatura ativado: Monitorando a temperatura ambiente.");
    }

    public void Desativar()
    {
        Console.WriteLine("Sensor de Temperatura desativado: Parando o monitoramento da temperatura.");
    }
}