namespace CalculoJuros
{
    class EmprestimoEstudante : IEmprestimo
    {
        public decimal CalcularValorFinal(decimal valor, int meses)
        {
            decimal taxa = 0.01m; // 1% ao mês
            decimal valorFinal = valor + (valor * taxa * meses);
            return valorFinal;
        }
    }
}