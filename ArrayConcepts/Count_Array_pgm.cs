//COUNTING THE FREQUENCY OF ELEMENTS IN AN ARRAY
using System;
using System.Collections.Generic;
class Count_Array_pgm
{
    static void Main()
    {
        string[] words = { "csharp", "dotnet", "csharp", "array", "dotnet" };
        Dictionary<string, int> freq = new Dictionary<string, int>();
        foreach (string w in words)
        {
            if (freq.ContainsKey(w))
                freq[w]++;
            else
                freq.Add(w, 1);
        }
        foreach (var item in freq)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}
