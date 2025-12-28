class ContaPremium(string nome, string email, DateTime dataExpiracao, DateTime dataCriacao)
{
    public string Nome { get; } = nome;
    public string Email { get; } = email;
    public DateTime DataExpiracao { get; } = dataExpiracao;
    public DateTime DataCriacao { get; } = dataCriacao;

    public bool EstaAtiva()
    {
        return DateTime.Now < DataExpiracao;
    }       
}

//Representa uma conta premium ou assinatura paga, desbloqueando recursos adicionais, como reprodução ilimitada, qualidade de áudio superior, etc.