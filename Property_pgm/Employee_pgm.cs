using System;
class Employee
{
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double Allowance { get; set; }

    public double NetSalary
    {
        get { return BasicSalary + HRA + Allowance; }
    }
}
class Employee_pgm
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.BasicSalary = 20000;
        emp.HRA = 5000;
        emp.Allowance = 3000;

        Console.WriteLine("Net Salary: " + emp.NetSalary);
    }
}