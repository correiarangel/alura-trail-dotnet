Console.WriteLine("\n*** Sistema cadastro de montagem de computadores ***\n");



Processador cpu = new Processador("AMD", "PROCESSADOR AM5 RYZEN 9 9900X");
PlacaMae mobo = new PlacaMae("ASUS", "AM5");
Computador pc = new Computador(cpu, mobo);

pc.ExibirConfiguracao();