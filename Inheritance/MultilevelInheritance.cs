//THERE SHOULD BE THREE CLASSES PERSON,STUDENT,GRADUATESTUDENT. STUDENT WILL INHERIT THE PERSON CLASS AND GRADUATESTUDENT STUDENT WILL INHERIT THE STUDENT CLASS.
//GET NAME , ROLL NUMBER AND PROJECT TITLE IN EACH CLASSES AND DISPLAY ALL.

using System;
class Person
{
     string Name;

    public void GetName()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
    }
    public void DisplayName()
    {
            Console.WriteLine("Name: " + Name);
     }
}

class Student : Person
{
     int RollNumber;

    public void GetRollNumber()
    {
        Console.Write("Enter Roll Number: ");
        RollNumber = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayRollNumber()
    {
        Console.WriteLine("Roll number: " + RollNumber);
    }
}

class GraduateStudent : Student
{
    public string ProjectTitle;

    public void GetProjectTitle()
        {
            Console.Write("Enter Project Title: ");
            ProjectTitle = Console.ReadLine();
    }
    public void DisplayProfile()
    {
        DisplayName();
        DisplayRollNumber();
        Console.WriteLine("Project title: " + ProjectTitle);
    }
}

class MultilevelInheritance
{
    static void Main()
    {
        GraduateStudent obj = new GraduateStudent();
        obj.GetName();
        obj.GetRollNumber();
        obj.GetProjectTitle();
        obj.DisplayProfile();
    }
}