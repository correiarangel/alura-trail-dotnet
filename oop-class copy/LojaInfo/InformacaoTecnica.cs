public class InformacaoTecnica
{
    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }
}