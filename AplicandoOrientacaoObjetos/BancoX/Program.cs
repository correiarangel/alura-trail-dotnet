
using System.Diagnostics;
using BancoX;


Conta conta = new Conta(
    new Titular("Ana Silva", "123.456.789-00", new DateTime(1990, 5, 20)),
    "0001",
    "12345-6",
    1500.75m,
    500.00m
);  

conta.Titular.ExibeInfo();

conta.ObterInformacoesDetalhadas();
    

