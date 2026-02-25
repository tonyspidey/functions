//Demo with Employee class which creates the object for Address class(Dor no, street name, locality, city, pincode)

using System;
 class Address
{
     string doorNo, streetname, locality, city;
     int pincode;

    public Address(string door, string sn, string loc, string c, int pin)
    {
        doorNo = door;
        streetname = sn;
        locality = loc;
        city = c;
        pincode = pin;
    }

    public void Display()
    {
        Console.WriteLine("Door No: " + doorNo);
        Console.WriteLine("Street Name: " + streetname);
        Console.WriteLine("Locality: " + locality);
        Console.WriteLine("City: " + city);
        Console.WriteLine("Pincode: " + pincode);
    }
}

class EmployeeAddress
{
     int eid;
     string ename;
     Address empaddress; 

    public EmployeeAddress(int id, string name, string door, string sn, string loc, string c, int pin)
    {
        eid = id;
        ename = name;
        empaddress = new Address( door, sn, loc, c, pin);
    }

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID: " + eid);
        Console.WriteLine("Employee Name: " + ename);
        empaddress.Display();
    }
}

class Aggregationpgm
{
    static void Main()
    {
        EmployeeAddress obj2 = new EmployeeAddress(105,"john", "1A","Cheranroad","Vilankurichi","coimbatore",641051);
        obj2.DisplayEmployee();
    }
}
