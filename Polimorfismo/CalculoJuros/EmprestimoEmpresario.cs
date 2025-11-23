namespace CalculoJuros
{
    class EmprestimoEmpresario : IEmprestimo
    {
        private const decimal Taxa = 0.025m; // 2.5% ao mês

        public decimal CalcularValorFinal(decimal valor, int meses)
        {
            return valor + (valor * Taxa * meses);
        }
    }
}