//CALCULATE ELECTRICITY BILL BASED UPON TYPE

using System;
class Bill
{
    string type;
    double pr, cr, amt, unit;

    public void Details()
    {
        Console.WriteLine("enter the previous reading :");
        pr = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the current reading :");
        cr = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the type(Residential or Commercial) :");
        type = Console.ReadLine();

    }
    public void Calculate()
    {
        unit = cr - pr;
        if (type == "Residential")
        {
            if (unit <= 100)
                amt = 0;
            else if (unit <= 200)
                amt = (unit - 100) * 2.25;
            else if (unit <= 500)
                amt = (unit - 200) * 4.5 + 100 * 2.25;
            else
                amt = (unit - 500) * 6 + 200 * 4.5 + 100 * 2.5;
        }
        else if (type == "Commercial")
        {
            if (unit <= 100)
                amt = 0;
            else if (unit <= 400)
                amt = (unit - 100) * 4.5;
            else if (unit <= 700)
                amt = (unit - 400) * 6 + 100 * 4.5;
            else if (unit <= 1000)
                amt = (unit - 700) * 9 + 400 * 6 + 100 * 4.5;
            else
                amt = (unit - 1000) * 10 + 700 * 9 + 400 * 6 + 100 * 4.5;
        }
        else
        {
            Console.WriteLine("invalid type");
        }

    }
    public void Display()
    {
        Console.WriteLine("The amount is :" + amt);
    }
}

class Electricity
{
    static void Main(string[] args)
    {
        Bill b = new Bill();
        b.Details();
        b.Calculate();
        b.Display();
    }
}


