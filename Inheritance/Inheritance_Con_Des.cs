//TWO CLASSES ACCOUNT AND SAVINGS ACCOUNT USING CONSTRUCTOR ASSIGN THE VALUE AND DISPLAY 

using System;
class Account
{
     int accountNumber;

    public Account(int acc)
    {
        accountNumber = acc;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number :"+ accountNumber);
    }

    ~Account()
    {
        Console.WriteLine("Destructor for Account class");
    }
}

class SavingsAccount : Account
{
     double balance;

    public SavingsAccount(int acc, double bal) : base(acc)
    {
        balance = bal;
    }

    public void Display()
    {
        DisplayDetails();
        Console.WriteLine("Balance: " + balance);
    }
}

class Inheritance_Con_Des
{
    static void Main(String[] args)
    {
        SavingsAccount obj = new SavingsAccount(12345, 50000);
        obj.Display();
    }
}