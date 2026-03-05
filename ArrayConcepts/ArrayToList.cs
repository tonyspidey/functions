//CONVERTING AN ARRAY TO A LIST

using System;
using System.Collections.Generic;

class ArrayToList
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30 };
        List<int> arr2 = new List<int>(arr);

        foreach (int x in arr2)
        {
            Console.WriteLine(x);
        }
    }
}