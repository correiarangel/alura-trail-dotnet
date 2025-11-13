using SistemaPagamento;

class PagamentoCredito(string nome, string email) : Pessoa(nome, email), IPagamento
{
    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento com cartão de crédito para {Nome} ({Email})");
    }
}