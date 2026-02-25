//CALCULATE TOTAL AND AVERAGE OF STUDENTS FOR 5 MARKS 

using System;
class Student
{
    public string name;
    public  int m1, m2, m3, m4, m5, total;
    double avg;

    public Student()
    {
        name = " ";
        m1 = m2 = m3 = m4 = m5 = 0;
        total = 0;
        avg = 0;
    }

    public void SetData(string n,int a, int b, int c, int d, int e)
    {
        name = n;
        m1 = a;
        m2 = b;
        m3 = c;
        m4 = d;
        m5 = e;
    }

    public void Calculate()
    {
        total = m1 + m2 + m3 + m4 + m5;
        avg = (double)total / 5.0;
    }
    public void Display()
    {
        Console.WriteLine("Name :" + name);
        Console.WriteLine("Total :" + total);
        Console.WriteLine("Average :" + avg);
    }
}

class Constructorpgm
{
    static void Main(String[] args)
    {
        string name;
        int m1, m2, m3, m4, m5;



        Console.WriteLine("Enter the name of the student:");
        name = Console.ReadLine();
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

        Student s1= new Student();

        s1.SetData(name, m1, m2, m3, m4, m5);
        s1.Calculate();
        s1.Display();

        Student s2 = new Student();
        s2.SetData("Adi", 60,70,80,90,99);
        s2.Calculate();
        s2.Display();

       
    }
}