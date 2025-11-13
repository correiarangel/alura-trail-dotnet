using SistemaPagamento;

Console.WriteLine("\n*** Sistema cadastro de pagamentos ***\n");



PagamentoCredito cliente1 = new PagamentoCredito("Juca Pirama", "piraj@email.com");
PagamentoBoleto cliente2 = new PagamentoBoleto("Juduti ", "juduti@email.com");

cliente1.ProcessarPagamento();
cliente2.ProcessarPagamento();