//TWO INTERFACE ONE HAS INPUT AND DISPLAY AND ANOTHER ONE FOR CALCULATION. IF AGE IS GREATER THAN 18 THEN DISPLAY ELIGIBLE FOR VOTING OTHERWISE NOT ELIGIBLE FOR VOTING.
//IF AGE IS GREATER THAN 60 RETIRED OTHERWISE NOT RETIRED. IN CLASS GET THE USER NAME,AGE , GENDER DOB ADDRESS AND DISPLAY THE DETAILS.

using System;
interface IDetails
{
    void GetDetails();
    void Display();
}

interface ICalculate
{
    void CheckAge();
    void CheckRetirement();
}

class Person : IDetails, ICalculate
{
    string name, gender, address;
    int age;
    DateOnly dob;

    public void GetDetails()
    {
        Console.WriteLine("Enter Name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter Age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter gender:");
        gender = Console.ReadLine();
        Console.WriteLine("Enter DOB:");
        dob = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter Address:");
        address = Console.ReadLine();
    }

    public void CheckAge()
    {
        if (age > 18)
        {
            Console.WriteLine("Eligible for Voting");
        }
        else
        {
            Console.WriteLine("Not Eligible for Voting");
        }
    }

    public void CheckRetirement()
    {
        if (age >= 60)
        {
            Console.WriteLine("Retirement age");
        }
        else
        {
            Console.WriteLine("working age");
        }
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("gender: " + gender);
        Console.WriteLine("DOB: " + dob);
        Console.WriteLine("Address: " + address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person obj = new Person();
        obj.GetDetails();
        obj.Display();
        obj.CheckAge();
        obj.CheckRetirement();
    }
}