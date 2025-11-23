namespace CalculoJuros
{
    interface IEmprestimo
    {
        decimal CalcularValorFinal(decimal valor, int meses);
    }
}