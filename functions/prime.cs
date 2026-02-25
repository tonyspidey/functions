//Prime number

using System;
class prime
{
    static bool calculate(int n)
    {
        int count = 0;
        for (int i = 2; i < n / 2; i++)
        {
            if (n % i == 0)
            {
                count++;
                return false;
            }
        }
        return true;

    }
    static void Main(String[] args)
    {
        Console.WriteLine("enter the number:");
        int a =Convert.ToInt32(Console.ReadLine());
        bool result = calculate(a);
        if(result==false)
        {
            Console.WriteLine(a+" is not a prime number");
        }
        else
        {
            Console.WriteLine(a+" is a prime number");
        }
    }
    
}