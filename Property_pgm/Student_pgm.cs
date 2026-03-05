//GET STUDENT DETAILS USING PROPERTIES

using System;
class Student
{
    private int _rollNo;
    private string _name;
    private int _marks;
    public int RollNo
    {
        get { return _rollNo; }
        set { _rollNo = value; }
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (value==" ")
                Console.WriteLine("Name cannot be empty");
            else
                _name = value;
        }
    }
    public int Marks
    {
        get { return _marks; }
        set
        {
            if (value >= 0 && value <= 100)
                _marks = value;
            else
                Console.WriteLine("Invalid Marks");
        }
    }
}
class Student_pgm
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.RollNo = 56;
        s.Name = "Harsha";
        s.Marks = 90;
        Console.WriteLine($"{s.RollNo} {s.Name} {s.Marks}");
    }
}