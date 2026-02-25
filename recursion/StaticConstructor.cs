//PROGRAM WITH STATIC CONSTRUCTOR 

using System;
class Employee
{
    public string name;
    static string officename;
    
     static Employee()
    {
        officename = "CG-VAK Software";
    }
    public Employee()
    {
        name = " ";
    }

    public void Display()
    {
        Console.WriteLine("Employee name:" + name);
        Console.WriteLine("Office Name:" + officename);
    }
}

class StaticConstructor
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the employee name");
        string n=Console.ReadLine();

        Employee e = new Employee();
        e.name = n;
        e.Display();
    }
}