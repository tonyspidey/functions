using System;
class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circle: Shape
{
    double radius = 5;
    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}

class Rectangle : Shape
{
    double length = 4;
    double breadth = 6;
    public override double Area()
    {
        return length * breadth;
    }
}

class Triangle : Shape
{
    double triangelbase = 4;
    double height = 5;
    public override double Area()
    {
        return  (triangelbase * height)/2.0;
    }
}

class Shape_pgm
{
    static void Main(string[] args)
    {
        Shape s;
        s = new Circle();
        s = new Rectangle();
        s = new Triangle();

        Console.WriteLine("Area of Circle: " + s.Area());
        Console.WriteLine("Area of Rectangle: " + s.Area());
        Console.WriteLine("Area of Triangle: " + s.Area());
    }
}