//CONVERTING ARRAY TO A DICTIONARY

using System;
using System.Collections.Generic;

class ArrayToDictionary
{
    static void Main(string[] args)
    {
        string[] name = { "prakash", "victor", "suresh" };
        Dictionary<int, string> dict = new Dictionary<int, string>();

        for (int i = 0; i < name.Length; i++)
        {
            dict.Add(i, name[i]);
        }

        foreach (var item in dict)
            Console.WriteLine(item.Key + ":" + item.Value);
    }
}