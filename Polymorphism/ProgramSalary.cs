using System;
class SalaryCalculator
{
    public int CalculateSalary(int basic)
    {
        return basic;
    }
    public int CalculateSalary(int basic, int hra)
    {
        return basic + hra;
    }
    public int CalculateSalary(int basic, int hra, int allowance)
    {
        return basic + hra + allowance;
    }
}
class ProgramSalary
{
    static void Main(string[] args)
    {
        SalaryCalculator sc = new SalaryCalculator();

        Console.WriteLine("Basic Salary is:" + sc.CalculateSalary(10000));
        Console.WriteLine("Basic Salary  + HRA: " + sc.CalculateSalary(10000, 2000));
        Console.WriteLine("Salary with Basic + HRA + Allowance: " + sc.CalculateSalary(10000, 2000, 1500));
    }
}