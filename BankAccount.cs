namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    private static int accountNumberSeed = 1234567890;

    public BankAccount(string name, decimal initialBalance)
    {
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
        this.Owner = name;
        this.Balance = initialBalance;

        
    }
    public void MadeDeposit(decimal amount, DateTime date, string note)
    {

    }

    public void MakeWithDrawl(decimal amount, DateTime date, string note)
    {

    }
}
