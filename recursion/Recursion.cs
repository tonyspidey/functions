//SUM OF N NUMBER USING RECURSION 

using System;
class Recursion
{
    public static int Sum(int n)
    {    
        if (n == 0)
        {
            return 0;
        }
        else
        {
            return n + Sum(n - 1);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int result=Recursion.Sum(n);
        Console.WriteLine("Sum of first " + n + " numbers is: " + result);
    }
}