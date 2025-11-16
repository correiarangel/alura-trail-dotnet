class Passageiro(string nome, int idade,int quantidadeBilhetes) : Pessoa(nome, idade)
{
    public int QuantidadeBilhetes { get; set; } = quantidadeBilhetes;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Quantidade de Bilhetes: {QuantidadeBilhetes}");
    }
}