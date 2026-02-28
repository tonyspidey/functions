//PERSON CLASS ALL DETAILS GET DOB CALCULATE AGE, INTERFACE INPUT AND OUTPUT.PROCESS INTERFACE HAS EARNING CALCULATION,TAX,PF. 
//EMPLOYEE CLASS IMPLEMENTS BOTH INTERFACE. GET EMPLOYEE DETAILS AND CALCULATE EARNING AND DISPLAY ALL DETAILS AND GROSS PAY AND NET PAY

using System;
interface IPersonDetails
{
    void GetPersonDetails();
    void DisplayDetails();
}

interface ICalculation
{
    void CalculateGross();
    void CalculateDeduction();
   
}

class PersonDetails
{
    protected string name;
    protected DateOnly dob;
    protected int age;

    public int CalculateAge()
    {
        return DateTime.Now.Year - dob.Year;
    }
}

class Employee : PersonDetails, IPersonDetails, ICalculation
{
    DateOnly joiningdate;
    string department;
    double net, bs, pf, tax, gross, hra, da, ded;

    public int CalculateExperience()
    {
        return DateTime.Now.Year - joiningdate.Year;
    }

    public void GetPersonDetails()
    {
        Console.WriteLine("Enter Name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter DOB in (mm/dd/yyyy):");
        dob = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter Joining Date in (mm/dd/yyyy):");
        joiningdate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter Department:");
        department = Console.ReadLine();
        Console.WriteLine("Enter Basic Salary:");
        bs = Convert.ToDouble(Console.ReadLine());
    }
    public void CalculateGross()    

    {
        hra = bs* 0.20;
        da = bs * 0.10;
        gross = bs + hra + da;
    }

    public void CalculateDeduction()
    {
        pf = bs * 0.20;
        tax = bs * 0.10;
        ded = pf + tax;
    }

   public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("DOB: " + dob.ToString("dd/MM/yyyy"));
        Console.WriteLine("Age: " + CalculateAge());
        Console.WriteLine("Joining Date: " + joiningdate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Experience: " + CalculateExperience()+ " year's experience");
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Basic Salary: " + bs);
        Console.WriteLine("Gross Salary: " + gross);
        Console.WriteLine("Deductions: " + ded);
        net = gross - ded;
        Console.WriteLine("Net Salary: " + net);
    }
}
class Basic_salary
{
    static void Main(string[] args)
    {
        Employee obj = new Employee();
        obj.GetPersonDetails();
        obj.CalculateGross();
        obj.CalculateDeduction();
        obj.CalculateAge();
        obj.CalculateExperience();
        obj.DisplayDetails();
    }
}   