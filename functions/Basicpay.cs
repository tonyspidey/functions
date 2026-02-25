//CALCULATE BASIC PAY OF EMPLOYEE 

using System;
class Salary
{
    int code;
    string name, dept;
    double bp, da, hra, pf, tax;
    double gross, deduction, net;

    public void Details()
    {
        Console.WriteLine("enter the employee code :");
        code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the name:");
        name = Console.ReadLine();
        Console.WriteLine("enter the department");
        dept = Console.ReadLine();
        Console.WriteLine("enter the basic pay:");
        bp = Convert.ToDouble(Console.ReadLine());
    }
    public void Calculate ()
    {
        if (bp > 20000)
        {
            da = 0.585 * bp;
            hra = 0.12 * bp;
            pf = 0.20 * bp;
            tax = 0.17 * bp;
        }
        else if (bp > 15000)
        {
            da = 0.46 * bp;
            hra = 0.12 * bp;
            pf = 0.15 * bp;
            tax = 0.12 * bp;
        }
        else
        {
            da = 0.425 * bp;
            hra = 1500;
            pf = 0.10 * bp;
            tax = 0;
        }
        gross = bp + da + hra;
        deduction = pf + tax;
        net = gross - deduction;
    }
    public void Display()
    {
        Console.WriteLine("Gross Pay:" + gross);
        Console.WriteLine($"net pay :{net}");
    }
}

class Basicpay
{
    static void Main(string[] args)
    {
        Salary s = new Salary();
        s.Details();
        s.Calculate();
        s.Display();
    }
}

