namespace DispositivosSensores
{
    class SensorPresenca : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de presença ativado: Monitorando movimento.");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de presença desativado: Parando o monitoramento de movimento.");
        }
    }
}