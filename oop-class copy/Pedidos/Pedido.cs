public class Pedido(string numeroPedido, string nomeCliente, string status)
{
    public string NumeroPedido { get; set; } = numeroPedido;
    public string NomeCliente { get; set; } = nomeCliente;
    public string Status { get; set; } = status;

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine("Pedido nº " + NumeroPedido);
        Console.WriteLine("Cliente: " + NomeCliente);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine();
    }
}