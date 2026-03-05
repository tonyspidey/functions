using System;
class Employee
{
    public virtual void ShowRole()
    {
        Console.WriteLine("The employee is an developer");
    }
}
class Manager : Employee
{
    public new void ShowRole()
    {
        Console.WriteLine("The employee is an AIML developer");
    }
}

class Employee_pgm
{
    static void Main(string[] args)
    {
        Manager m = new Manager();
        Employee e = new Employee();

        m.ShowRole();
        e.ShowRole();
    }
}