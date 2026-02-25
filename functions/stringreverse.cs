//palindrome for string 

using System;
class stringreverse
{
    //static string reverse(string txt)
    //{
    //    string reversed = " ";
    //    for (int i = txt.Length - 1; i >= 0; i--)
    //    {
    //        reversed += txt[i];
    //    }
    //    return reversed;
    //}
    static void calculate(string name,int age,out string message,out bool result,out int l)
    {
       message = ($"Age of {name} is {age}");
        if(age>18)
        {
             result = true ;
        }
        else
        {
            result = false;
        }

        l = name.Length;
    }
   
    static void Main(String[] args)
    {
        //Console.WriteLine("enter the string");
        //string text = Console.ReadLine();
        //string result= reverse(text);
        //Console.WriteLine("The reversed string is:" + result);
        Console.WriteLine("Enter the name and age : ");
        string a = Console.ReadLine();
        int b = Convert.ToInt32(Console.ReadLine());
        string text;
        bool vote;
        int len;
        calculate(a,b,out text,out vote,out len);
     
        if (vote==true)
        {
            Console.WriteLine($"{a} is eligible to vote");
        }
        else
        {
            Console.WriteLine($"{a} is not eligible to vote");
        }

        Console.WriteLine($"{text}");
        //Console.WriteLine($"{vote}");
        Console.WriteLine($"The length of the string is :{len}");
    }

}