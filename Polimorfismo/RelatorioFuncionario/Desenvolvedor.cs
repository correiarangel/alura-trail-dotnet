namespace RelatorioFuncionario
{
    class Desenvolvedor : Funcionario
    {
        public override string GerarRelatorio()
        {
            return "**Relatório técnico do desenvolvedor**.\nTrabalhao em bugs";
        }
    }
}