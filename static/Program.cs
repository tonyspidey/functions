//CALCULATE TOTAL AND AVERAGE OF STUDENTS FOR 5 MARKS AND COUNT THE NO. OF PASS AND FAIL 

using System;
class Marks
{
    public string name;
    public char grade;
    public int m1, m2, m3, m4, m5, total;
    public double avg;
    static int passcount = 0, failcount = 0;

    public void Details()
    {
        Console.WriteLine("Enter the name of the student:");
        name = Console.ReadLine();
        Console.WriteLine("enter the grade of the student:");
        grade = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("enter the mark1:");
        m1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the mark2:");
        m2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the mark3:");
        m3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the mark4:");
        m4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the mark5:");
        m5 = Convert.ToInt32(Console.ReadLine());

        total = m1 + m2 + m3 + m4 + m5;
        avg = (double)total / 5.0;

        PassFail();
    }
    public void PassFail()
    {
        if(avg >= 50 )
        {
            passcount++;
        }
        else
        {
            failcount++;
        }
    }

    public void Display()
    {
        Console.WriteLine("Name :"+name);
        Console.WriteLine("Grade :" + grade);
        Console.WriteLine("Total :" + total);
        Console.WriteLine("Average :" + avg);
    }

    public static void Result()
    {
        Console.WriteLine("No.of Pass count in the class is :" + passcount);
        Console.WriteLine("No.of Fail count in the class is :" + failcount);

    }
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("enter no.of students :");
        int n=Convert.ToInt32(Console.ReadLine());
        Marks[] m = new Marks[n];
       for (int i = 0; i < n; i++)
        {
            m[i] = new Marks();   // Object iscreated individually
            m[i].Details();
            m[i].Display();
        }
        Marks.Result();
    }
}