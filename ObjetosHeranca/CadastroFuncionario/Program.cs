using CadastroFuncionario;

Console.WriteLine("\n*** Sistema cadastro de funcionários ***\n");


Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);  

Console.WriteLine("Funcionários cadastrados:\n");
Console.WriteLine(f1.ToString());
Console.WriteLine(f2.ToString());