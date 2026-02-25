//VOWELS 

using System;
class Vowels
{
    static int vowelsFinding(string text)
    {
        int count = 0;
        text=text.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int count = 0;
        int result = vowelsFinding("hashavardhan");
        Console.WriteLine("Number of vowels:"+result); 
    }
}