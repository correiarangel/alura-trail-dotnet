using DispositivosSensores;

Console.WriteLine("\n*** Sistema cadastro dispositivos com sensores ***\n");


SensorTemperatura temp = new SensorTemperatura();
SensorPresenca presenca = new SensorPresenca();

temp.Ativar();
temp.Desativar();

presenca.Ativar();
presenca.Desativar();