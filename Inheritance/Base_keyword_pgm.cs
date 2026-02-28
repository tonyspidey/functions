//THERE SHOULD BE TWO CLASSES COMPANY AND DEPARTMENT IN COMPANY GET THE COMPANYNAME AND ASSIGN THE VALUE USING CONSTRUCTOR . IN DEPARTMENT GET THE
//DEPARTMENT NAME AND ASSIGN THE VALUE USING CONSTRUCTOR.WITH BASE KEYWORD CALL THE METHOD AND DISPLAY 

using System;
class Company
{
     string companyName;

    public Company(string name)
    {
        companyName = name;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Company: " + companyName);
    }
}

class Department : Company
{
    string departmentName;

    public Department(string cname, string dname) : base(cname)
    {
        departmentName = dname;
    }

    public void Display()
    {
        base.DisplayDetails();  
        Console.WriteLine("Department: " + departmentName);
    }
}

class Base_Keyword_pgm
{
    static void Main()
    {
        Department d = new Department("CG - VAK ", "Developer");
        d.Display();
    }
}