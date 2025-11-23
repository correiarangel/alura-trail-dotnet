namespace RelatorioFuncionario
{
    class Gerente : Funcionario
    {
        public override string GerarRelatorio()
        {
            return "Relatório detalhado do gerente.**\nInterou com equipes e projetos.";
        }
    }
}