class ClienteVIP(string nome, int idade, string nivelFidelidade = "START", string codigoVIP = null) : Pessoa(nome, idade)
{
    public string NivelFidelidade { get; set; } = nivelFidelidade;
    public string CodigoVIP { get; set; } = codigoVIP;

    public override string ToString()
    {
        return $"Olá,{Nome} seje bem-vindo(a)!\nIdade: {Idade}\nNível de Fidelidade: {NivelFidelidade}\nCódigo VIP: {CodigoVIP}\n";
    }
}

/*

Instancie dois clientes VIP com dados fictícios.
Exiba no console uma mensagem formatada para cada cliente, incluindo:
Uma saudação personalizada .
Idade, nível de fidelidade e código VIP em linhas separadas.
*/