//GET EMPLOYEE ID ,NAME ,MONTHLY SALARY AND CALCULATE ANNUAL SALARY

using System;
class Employee
{
     int empId;
     string name;

    public void GetDetails()
    {
        Console.Write(" Employee ID: ");
        empId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();
    }
    public void DisplayDetails()
    {
        Console.WriteLine("ID: " + empId);
        Console.WriteLine("Name: " + name);
    }
}

class FullTimeEmployee : Employee
{
     double monthlySalary;
    public void GetSalaryDetails()
    {
        Console.Write("Enter Monthly Salary: ");
        monthlySalary = Convert.ToDouble(Console.ReadLine());
    }
    public void CalculateAnnualSalary()
    {
        double annualSalary = monthlySalary * 12;   
        
        Console.WriteLine("Annual Salary: " + annualSalary);
    }
}

class SingleInheritance
{
    static void Main(String[] args)
    {
        FullTimeEmployee obj = new FullTimeEmployee();
        obj.GetDetails();
        obj.GetSalaryDetails();
        obj.CalculateAnnualSalary();
        obj.DisplayDetails();
    }
}