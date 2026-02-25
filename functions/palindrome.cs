//FIND PALINDROME OR NOT 

using System;
class palindrome
{
    static bool show(int n)
    {
        int rev = 0;
        int org = n;
        while (n > 0)
        {
            rev = rev * 10 + (n % 10); 
            n /= 10;
        }
        if (org == rev)
            return true;
        else
            return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number");
        int a = Convert.ToInt32(Console.ReadLine());
        

        bool result=show(a);

        if(result==true)
        {
            Console.WriteLine(a +" is a palindrome");
        }
        else
        {
            Console.WriteLine(a +" is not a palindrome");
        }
    }
  
}