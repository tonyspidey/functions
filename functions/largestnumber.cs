//FIND THE LARGEST NUMBER 

using System;
class largestnumber
{
    static int greatnum(int a, int b, int c)
    {
        if(a>b && a>c)
        {
            return a;
        }
        else if(b>a &&b>c)
        {
            return b; 
        }
        else
        {
            return c;
        }

    }
    static void Main(String[] args)
    {
       
        Console.WriteLine("enter the number1");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the number2");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the number3");
        int z = Convert.ToInt32(Console.ReadLine());

        int max = greatnum(x, y, z);

        Console.WriteLine("The greatest number is : " +max);
    }
    
}