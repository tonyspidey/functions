using System;
abstract class  Vehicle
{
    public abstract void Start();
    public virtual void FuelType()
    {
        Console.WriteLine("Fuel types are");
    }
}
class PetrolCar : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Start the Petrol car");
    }
    public override void FuelType()
    {
        Console.WriteLine("fuel type : Petrol");
    }
}

class ElectricCar : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Start the Electric car");
    }
    public override void FuelType()
    {
        Console.WriteLine("fuel type : Electric");
    }
}
class Vehicle_pgm
{
    static void Main(string[] args)
    {
        Vehicle v;
        v = new PetrolCar();
        v = new ElectricCar();

        v.Start();
        v.FuelType();
       
        v.Start();
        v.FuelType();
    }
}