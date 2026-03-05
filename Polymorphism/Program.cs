//using System;
//class Vector
//{
//    public int X;
//    public int Y;
//    public Vector(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//    public static Vector operator +(Vector v1, Vector v2)
//    {
//        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Vector v1 = new Vector(2, 3);
//        Vector v2 = new Vector(4, 5);
//        Vector result = v1 + v2;
//        Console.WriteLine("Result of addition: X = " + result.X + ", Y = " + result.Y);
//    }
//}

//using System;
//class Base
//{
//    public Base()
//    {
//        Show();  
//    }
//    public virtual void Show()
//    {
//        Console.WriteLine("Base Show");
//    }
//}
//class Derived : Base
//{
//    string message = "Hello";
//    public override void Show()
//    {
//        Console.WriteLine(message);  
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Derived d = new Derived();
//    }
//}

//using System;
//class Dog
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Dog barks");
//    }
//}
//class Cat
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Cat meows");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        dynamic obj;

//        obj = new Dog();
//        obj.MakeSound();    

//        obj = new Cat();
//        obj.MakeSound();  
//    }
//}

using System;
class A
{
    public virtual void Show() => Console.WriteLine("A");
}
class B : A
{
    public override void Show() => Console.WriteLine("B");
}
class C : B
{
    public new void Show() => Console.WriteLine("C");
}
class Program
{
    static void Main()
    {
        A a = new C();
        a.Show();  
    }
}