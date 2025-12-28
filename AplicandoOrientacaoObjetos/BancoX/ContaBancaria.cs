
public class ContaBancaria(int numero, string titular, decimal saldo, string senha)
{
    private readonly int _numero = numero;
    private readonly string _titular = titular;
    private readonly decimal _saldo = saldo;
    private readonly string _senha = senha;

    public void ExibeInfo()
    {
        Console.Write($"\nConada: {_numero}\n Titular: {_titular}\n Saldo R$: {_saldo.ToString("f2")}\n");
    }
}
/*
Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
Desenvolver um método da classe Conta que exibe suas informações.
Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
*/