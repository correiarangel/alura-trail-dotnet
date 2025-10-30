internal class HistoricoMedico(string codigoProntuario)
{
    private string _codigoProntuario { get; set; } = codigoProntuario;
    public void ExibirCodigo() => Console.WriteLine($"Código do prontuário: {codigoProntuario}");
    
}