//GET PRODUCT CODE,NAME,QUANTITY AND PRICE . CALCULATE DISCOUNT AMOUNT AND FINAL PRICE.

using System;
class Product
{
    string name;
    int code, quantity;
    double price, total, da, fp;

    public void Details()
    {
        Console.WriteLine("enter the product code :");
        code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the product Quantity :");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the product Name :");
        name = Console.ReadLine();
        Console.WriteLine("enter the product Price :");
        price = Convert.ToDouble(Console.ReadLine());

    }

    public void Calculate()
    {
        total = quantity * price;
        da = total * 0.10;
        fp = total - da;
    }

    public void Display()
    {
        Console.WriteLine("the product code is :" + code);
        Console.WriteLine("the product name is :" + name);
        Console.WriteLine("the product quantity is :" + quantity);
        Console.WriteLine("the product price is :" + price);
        Console.WriteLine("the product Discount amount is :" + da);
        Console.WriteLine("the product final price is :" + fp);

    }
}

class Discount
{
    static void Main(string[] args)
    {
        Product p = new Product();
        p.Details();
        p.Calculate();
        p.Display();
    }
}