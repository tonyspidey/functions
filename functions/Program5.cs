//FIND PRIME OR NOT IT IT IS NOT FIND FACTORS AND CHECK IF IT IS A PERFECT NUMBER OR NOT . FIND THE REVERSE OF THE NO. AND COUNT OF THE DIGIT IN NUMBER.

using System;
class Check
{
    private int n;
    public void Setvalue(int num)
    {
       this.n = num;
    }

    public void PrimeorNot()
    {
        int count = 0;
        for (int i = 2;i<n/2;i++)
        {
            if(n%i==0)
            {
                count++;
                break;
            }
        }
        if(count ==1)
        {
            Console.WriteLine(n + "is not a prime number");
        }
        else
        {
            Console.WriteLine(n + "is  prime number");
        }
    }
    public void FactorsandPerfect()
    {
        int sum = 0;sum = n;
        Console.Write("The factors are :");
        for (int i = 2; i<n/2;i++)
        {
            if(n%i==0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.WriteLine();
        if(sum==n)
        {
            Console.WriteLine(n + " is a perfect number");
        }
        else
        {
            Console.WriteLine(n + " is not a perfect number");
        }
            
    }
    public void Reverse(out int rev,out int count)
    {
        rev = 0;
        count=0;
        while(n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
            count++;
        }
     
    }
}

class Program5
{
    static void Main(string[] args)
    {
        int  rev, count;
        Console.WriteLine("enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());
        Check c = new Check();
        c.Setvalue(num);
        c.PrimeorNot();
        c.FactorsandPerfect();
        c.Reverse(out rev, out count);
        Console.WriteLine("reverse :" + rev);
        Console.WriteLine("the count is :"+count);

    }
}