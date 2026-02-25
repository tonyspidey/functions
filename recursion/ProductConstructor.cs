//CALCULATE FINAL PRICE FOR THE PRODUCT 

using System;
class Product
{
    public string name;
    public int code, quantity;
    public double price, total, da, fp;

    public Product()
    {
        name = " ";
        code = quantity = 0;
        price =  0;
    }

    public Product(string n, int c, int q, double p)
    {
        name = n;
        code = c;
        quantity = q;
        price = p;
    }

    public Product(Product p)
    {
        name = p.name;
        code = p.code;
        quantity = p.quantity;
        price = p.price;
        total = p.total;
        da = p.da;
        fp = p.fp;
    }
    public void SetData(string n, int c, int q, double p)
    {
        name = n;
        code = c;
        quantity = q;
        price = p;
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

class ProductConstructor
{
    static void Main(string[] args)
    {
        string name;
        int code,quantity;
        double price;

        Product p = new Product();
        Product p2 = new Product("Laptop", 102, 1, 10000);
        Product p3 = new Product(p2);

        Console.WriteLine("enter the product code :");
        code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the product Quantity :");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the product Name :");
        name = Console.ReadLine();
        Console.WriteLine("enter the product Price :");
        price = Convert.ToDouble(Console.ReadLine());

     
        p.SetData(name, code, quantity, price);
        p.Calculate();
        p.Display();

        p2.Calculate();
        p2.Display();

        p3.Calculate();
        p3.Display();

    }
}