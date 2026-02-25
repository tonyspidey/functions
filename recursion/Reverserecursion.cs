//REVERSE A NUMBER USING RECURSION 

using System;
class Reverserecursion
    {
    static int rev = 0;
    public static int Reverse(int n)
    {
        if (n == 0)
        {
            return rev;
        }
        else
        {
            rev = rev * 10 + (n % 10);
            return Reverse(n / 10);
        }
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int result = Reverse(n);
            Console.WriteLine("Reversed number is: " + result);
        }
    }
   
