using System;
class sample_pgm
{
    static void Main(string[] args)
    {
        void Calculate(int a, int b,int c,out int sum)
        {
            sum = a + b-c;
        }
        int result;
        Calculate(5, 10,3, out result);
        Console.WriteLine(result);

        int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }
        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine(total);

        void Display(String name,int age=15)
        {
            Console.WriteLine("the name is " + name + " and his age is " + age);
        }
        Display("harsha");

        void show(string name,int age,string city="coimbatore")
        {
            Console.WriteLine($"his name is {name} and his age is {age} he lives in {city}");
        }
        show(age: 22, name: "harsha");


    }
}

