//FIND THE AREA OF TRIANGLE AND VOLUME OF CONE 

using System;
class AreaofTriangle
{
    static void Main(string[] args)
    {
        Func<double, double, double> Area = (b, h) => 1 / 2.0 * b * h;
        Func<double, double, double> VolumeofCone = (r, h) => 1 / 3.0 * Math.PI * Math.Pow(r, 2)* h;
         
        Console.WriteLine("Volume of Cone is :" + Math.Round(VolumeofCone(9,3),2));

        Console.WriteLine("Area of Triangle is :" + Area(5, 5));
    }
}