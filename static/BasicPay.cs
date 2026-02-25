//CALCULATE BASIC PAY USING ARRAY OF OBJECT 

using System;
class Operation
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
    public void Calculate()
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
       Console.Write("|"+name+"\t"+code+"\t"+dept+"\t"+bp+"\t"+gross+"\t"+net+"|");
        Console.WriteLine();
    }
}
class BasicPay
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter no.of employees");
        int n=Convert.ToInt32(Console.ReadLine());

        Operation[] o=new Operation[n];
        for(int i=0; i<n; i++)
        {
            o[i]=new Operation();
            o[i].Details();
            o[i].Calculate();
        }
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Name | Code | Dept | Basic Pay | Gross | Net |");
        Console.WriteLine("----------------------------------------------");

        for(int i=0; i<n;i++)
        {
            o[i].Display();
        }

    }
}