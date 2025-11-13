class Quarto(int numero)
{
    public int Numero { get; set; } = numero;

    private decimal valorDiaria;

    public decimal ValorDiaria
    {
        get { return valorDiaria; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O valor da diária deve ser positivo.");
                return;
            }
            valorDiaria = value;
        }
    }
}