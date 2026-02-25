using System;
class Factorial
{
    static void Main(string[] args)
    {
        Func<int, int> FactorialofNumber = null;

        FactorialofNumber = (n) =>
        {
            if (n <= 1)
                return 1;
            else
                return n * FactorialofNumber(n - 1);
        };

        Console.WriteLine("Factorial of number is : " + FactorialofNumber(5));
    }
}