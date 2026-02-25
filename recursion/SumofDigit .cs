//SUM OF DIGIT USING RECURSION 

using System;
class SumofDigit
{
    public static int Sum(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else
        {
            int dig = n % 10;
            return dig + Sum(n / 10);
        }
    }
static void Main(String[] args)
{
   Console.WriteLine("Enter a number :");
        int n = Convert.ToInt32(Console.ReadLine());
        int result=SumofDigit.Sum(n);
        Console.WriteLine("The Sum of Digit " + n + " is :" + result);
 }
}