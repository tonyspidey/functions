using System;
class Area
{
    public double Calculate(double radius)
    {
        return 3.14 * radius * radius;
    }

    public double Calculate(double length, double breadth)
    {
        return length * breadth;
    }

    public int Calculate(int side)
    {
        return side * side;
    }
}

class Area_pgm
{
       static void Main(string[] args)
    {
        Area a = new Area();

        Console.WriteLine("Area of Circle: " + a.Calculate(5.0));
        Console.WriteLine("Area of Rectangle: " + a.Calculate(4.0, 6.0));
        Console.WriteLine("Area of Square: " + a.Calculate(4));
    }
}