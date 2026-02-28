//ABSTRACT PROGRAM , OVERRIDE THE METHOD IN THE DERIVED CLASS AND CALL THE METHOD IN THE MAIN METHOD.

using System;
abstract class Vehicle
{
    public abstract void Start();
    public void Stop()
    {
        Console.WriteLine("Stop the Vehicle");
    }
}

class Car: Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Start the Car");
    }
}

class Bike: Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Start the Bike");
    }
}

class Abstract_class
{
    static void Main(string[] args)
    {
        Car obj = new Car();

        Bike obj2 = new Bike();

        obj.Start();
        obj.Stop();

        obj2.Start();
        obj2.Stop();
    }
}