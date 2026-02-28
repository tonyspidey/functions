//CALCULATE TOTAL AND AVERAGE OF STUDENTS FOR 5 MARKS 

using System;
class Student
{
      string name;
      int m1, m2, m3, m4, m5, total;
      double avg;

    public Student()
    {
        name = " ";
        m1 = m2 = m3 = m4 = m5 = 0;
        total = 0;
        avg = 0;
    }
    public Student(string nam, int ma1, int ma2, int ma3, int ma4, int ma5)
    {
        name = nam;
        m1 = ma1;
        m2 = ma2;
        m3 = ma3;
        m4 = ma4;
        m5 = ma5;
    }
    public Student(Student s)
    {
        name = s.name;
        m1 = s.m1;
        m2 = s.m2;
        m3 = s.m3;
        m4 = s.m4;
        m5 = s.m5;
    }
    public void SetData(string nam, int ma1, int ma2, int ma3, int ma4, int ma5)
    {
        name = nam;
        m1 = ma1;
        m2 = ma2;
        m3 = ma3;
        m4 = ma4;
        m5 = ma5;
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

        Student s1 = new Student();

        Student s2 = new Student("Adi", 60, 70, 80, 90, 99);

        Student s3 = new Student(s2);

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

        s1.SetData(name, m1, m2, m3, m4, m5);
        s1.Calculate();
        s1.Display();

        s2.Calculate();
        s2.Display();

        s3.Calculate();
        s3.Display();

    }
}