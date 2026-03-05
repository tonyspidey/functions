//CONVERTING A LIST TO AN ARRAY

using System;
using System.Collections.Generic;
class ListToArray
{
    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 10, 20, 30 };
        int[] arr2 = arr.ToArray();

        foreach (int x in arr2)
            Console.WriteLine(x);
    }
}