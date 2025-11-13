namespace SistemaPagamento
{
    class PagamentoBoleto(string nome, string email) : Pessoa(nome, email), IPagamento
    {
        public void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento com boleto bancário para {Nome} ({Email})");
        }
    }
}