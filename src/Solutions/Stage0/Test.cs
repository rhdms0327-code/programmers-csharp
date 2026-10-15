using System;
using System.Collections.Generic;
using System.Linq;

namespace P42577;

public class Solution
{
    public bool solution(string[] phone_book)
    {
        Array.Sort(phone_book, StringComparer.Ordinal);
        for (int i = 0; i + 1 < phone_book.Length; i++)
            if (phone_book[i + 1].StartsWith(phone_book[i], StringComparison.Ordinal))
                return false;
        return true;
    }
}