using System;
class Bank
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Select the Bank");
    }
}
class SBI : Bank
{
    public override void CalculateInterest()
    {
        Console.WriteLine("SBI interest is 5%");
    }
}
class HDFC : Bank
{
    public override void CalculateInterest()
    {
        Console.WriteLine("HDFC interest is 6%");
    }
}
class ICICI : Bank
{
    public override void CalculateInterest()
    {
        Console.WriteLine("ICICI interest is 7%");
    }
}

class Bank_pgm
{
    static void Main(string[] args)
    {
        Bank b;
        b = new SBI();
        b = new HDFC();
        b = new ICICI();
        
        b.CalculateInterest();
      
        b.CalculateInterest();
       
        b.CalculateInterest();
    }
}