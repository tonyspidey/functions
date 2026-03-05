//GET AGE USING PROPERTIES AND DISPLAY 

using System;
class Person
{
    public string Name { get; set; }
    public int BirthYear { get; set; }

    public int Age
    {
        get { return DateTime.Now.Year - BirthYear; }
    }
}
class Age_pgm
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Harsha";
        p.BirthYear = 2004;

        Console.WriteLine("Age: " + p.Age);
    }
}