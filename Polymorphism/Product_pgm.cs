using System;
class Product
{
    public virtual void GetDiscount()
    {
        Console.WriteLine("Product Discount");
    }
}

class Electronics : Product
{
    public override void GetDiscount()
    {
        Console.WriteLine("Electronics Discount is 7%");
    }
}

class Furniture : Product
{
    public new void GetDiscount()
    {
        Console.WriteLine("Furniture Discount is 10%");
    }
}

class Product_pgm
{
    static void Main(string[] args)
    {
        Product p;
        p = new Electronics();
        p = new Furniture();

        p.GetDiscount();
        p.GetDiscount();
    }
}