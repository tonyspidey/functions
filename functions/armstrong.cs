//FIND THE ARMSTRONG NUMBER 

using System;
class armstrong
{
    static bool calculate(int n)
    {
        int dig, org = n;
        double dig1, sum = 0;
        while (n > 0)
        {
            dig = n % 10;
            dig1 = Math.Pow(dig, 3);
            sum += dig1;
            n /= 10;
           
        }
        if (org != sum)
                return false;
         else 
            return true; 
    }
    static void Main(String[] args)
    {
        Console.WriteLine("enter the number");
        int a =Convert.ToInt32(Console.ReadLine());
        bool result = calculate(a);
            
        if(result==true)
        {
            Console.WriteLine(a+ " is armstrong number");
        }
        else
        {
            Console.WriteLine(a+ " is not a armstrong number");
        }
    }
   
}