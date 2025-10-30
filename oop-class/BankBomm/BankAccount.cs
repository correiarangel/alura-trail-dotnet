class BankAccount(string accountNumber,decimal initialBalance) 
{
    public string AccountNumber { get; set; } = accountNumber;
    public decimal Balance { get; set; } = initialBalance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
     public void Sake(decimal amount){
        Balance -= amount;
     }

    public void ViewBalance()
    {
        Console.WriteLine($"Saldo atual: {Balance}");
    }
}
