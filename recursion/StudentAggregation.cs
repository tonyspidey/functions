// GET STUDENT NAME GRADE SECTION GENDER PARENT NAME 

using System;
class StudentDetails
{
     int grade;
     char section;
     char gender;
     string fathername;
     string mothername;

    public StudentDetails(int g,char s,char gen,string fn,string mn)
    {
        grade = g;
        section = s;
        gender = gen;
        fathername = fn;
        mothername = mn;
    }
    public void Display()
    {
        Console.WriteLine("Student grade is :" + grade);
        Console.WriteLine("Student Section is :" + section);
        Console.WriteLine("Student gender is :" + gender);
        Console.WriteLine("Student's Father Name is :" + fathername);
        Console.WriteLine("Student's Mother Name is :" + mothername);
    }
}

class Students
{
      string name;
      int age;
      StudentDetails details;

    public Students(string n,int a, int g, char s, char gen, string fn,string mn)
    {
        name = n;
        age = a;
        details = new StudentDetails(g,s,gen,fn,mn);
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Student name is :" + name);
        Console.WriteLine("Student age is :" + age);
        details.Display();
    }
}
class StudentAggregation
{
    static void Main(String[] args)
    {
        Students obj = new Students("Jack",15,12,'A','M',"John","Rose");
        obj.DisplayDetails();
    }
}