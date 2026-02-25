//CALCUATE TOTAL AVERAGE AND PERCENTAGE OF 5 MARKS 

using System;
class Marks
{
    string name;
    char grade;
    int m1, m2, m3, m4, m5, total;
    double avg;

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

    }
    public void Calculate()
    {
        total = m1 + m2 + m3 + m4 + m5;
        avg = (double)total / 5.0;
    }
    public void Display()
    {
        Console.WriteLine("Name :" + name);
        Console.WriteLine("Grade :" + grade);
        Console.WriteLine("Total :" + total);
        Console.WriteLine("Average :" + avg);
    }
}

class Programs
{
    static void Main(String[] args)
    {
        Marks m = new Marks();
        m.Details();
        m.Calculate();
        m.Display();

    }
}


