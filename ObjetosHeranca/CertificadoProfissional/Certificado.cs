class Certificado
{
    private readonly Profissao profissao;

    public Certificado(Profissao profissao)
    {
        this.profissao = profissao;
    }

    public void ExibirCertificado()
    {
        Console.WriteLine($"Certificado emitido para: {profissao.nome} esta apto a atuar como {profissao.titulo} ");
    }
}