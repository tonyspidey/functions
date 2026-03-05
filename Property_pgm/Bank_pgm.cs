//GET BANK ACCOUNT DETAILS USING PROPERTIES

using System;
class BankAccount
{
    private double _balance;
    public string AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
                _balance = value;
            else
                Console.WriteLine("Balance cannot be negative");
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
        else
            Console.WriteLine("Deposit amount should be positive ");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Invalid Withdraw Amount");
    }
}
class Bank_pgm
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.AccountNumber = "ACC1001";
        acc.HolderName = "Harsha";
        acc.Balance = 5000;

        acc.Deposit(2000);
        acc.Withdraw(3000);

        Console.WriteLine("Final Balance: " + acc.Balance);
    }
}