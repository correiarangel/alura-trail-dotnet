internal partial class Program
{

    private static void Main(string[] args)
    {
        Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
        Console.WriteLine("\nPedido\n");
        pedido.ExibirPedido();
        pedido.AtualizarStatus("Enviado");
        pedido.ExibirPedido();
        pedido.AtualizarStatus("Entregue");
        pedido.ExibirPedido();
        pedido.AtualizarStatus("Regeitadoe");
        pedido.ExibirPedido();
        Console.WriteLine("-------------------------------");
        Pedido pedido2 = new Pedido("002", "Paulninho Mosca", "Pendente");
        Console.WriteLine("\nPedido\n");
        pedido2.ExibirPedido();
        pedido2.AtualizarStatus("Enviado");
        pedido2.ExibirPedido();
        pedido2.AtualizarStatus("Entregue");
        pedido2.ExibirPedido();
    }

}