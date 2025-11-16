Console.WriteLine("\n*** Sistema de registro de clientes ***\n");

ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");  
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");  
ClienteVIP cliente3 = new ClienteVIP("Dick Vigarista", 60, "Diamante", "VIP123Q"); 


Console.WriteLine($"{cliente1.ToString()}\n{cliente2.ToString()}\n{cliente3.ToString()}");

