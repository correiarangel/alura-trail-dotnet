namespace CalculoJuros
{
    class EmprestimoAposentado : IEmprestimo
    {
        private const decimal Taxa = 0.015m; // 1.5% ao mês

        public decimal CalcularValorFinal(decimal valor, int meses)
        {
            return valor + (valor * Taxa * meses);
        }
    }
}