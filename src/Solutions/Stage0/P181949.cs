using System;

namespace P181949;

public class Example
{
    public static void Main()
    {
        String s;

        // Console.Clear();
        s = Console.ReadLine();

        char[] text = s.ToCharArray();
        char[] result = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            result[i] = Char.IsUpper(text[i]) ? Char.ToLower(text[i]) : Char.ToUpper(text[i]);
        }

        Console.WriteLine(result);
    }
}