class Reserva
{
    private int diarias;

    public Hospede Hospede { get; }
    public Quarto Quarto { get; }

    public decimal ValorTotal
    {
        get
        {
            return diarias * Quarto.ValorDiaria;
        }
    }

    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        if (diarias <= 0)
        {
            Console.WriteLine("A quantidade de diárias deve ser maior que zero.");
            throw new ArgumentException("A quantidade de diárias deve ser maior que zero.");
        }

        Hospede = hospede;
        Quarto = quarto;
        this.diarias = diarias;
    }
}