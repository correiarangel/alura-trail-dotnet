Console.WriteLine("\n*** Sistema de reservas em hotel ***\n");

Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);

Console.WriteLine($"\n Reserva para {reserva.Hospede.Nome}");
Console.WriteLine($" Quarto número: {reserva.Quarto.Numero}");
Console.WriteLine($" Valor diária: {reserva.Quarto.ValorDiaria:C}");
Console.WriteLine($" Total de diárias: {reserva.ValorTotal:C}\n");

/*

Crie:

Classe Hospede:

Propriedade pública Nome, definida no construtor
Classe Quarto:

Propriedade pública Numero
Propriedade ValorDiaria, com get e set, validando que o valor seja positivo
Classe Reserva:

Campo privado diarias
Propriedade somente leitura Hospede (objeto)
Propriedade somente leitura Quarto (objeto)
Propriedade somente leitura ValorTotal (calculada)
Construtor que receba Hospede, Quarto e diarias, e valide se as diárias são maiores que zero

*/