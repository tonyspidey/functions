using System;
 abstract class Payment
{
    public abstract void ProcessPayment();
    public void GenerateReceipt()
    {
        Console.WriteLine("Receipt has generated");
    }
}
class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Payment through Creditcard");
    }
}
class UPIPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Payment through UPI");
    }
}
class NetBankingPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Payment through Net Banking");
    }
}
class Payment_pgm
{
    static void Main(string[] args)
    {
        Payment p;
        p = new CreditCardPayment();
        p = new UPIPayment();
        p = new NetBankingPayment();

        p.ProcessPayment();
        p.GenerateReceipt();
      
        p.ProcessPayment();
        p.GenerateReceipt();
       
        p.ProcessPayment();
        p.GenerateReceipt();
    }
}
