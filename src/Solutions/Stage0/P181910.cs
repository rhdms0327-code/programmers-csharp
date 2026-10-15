using System;
using System.Collections.Generic;
using System.Linq;

namespace P181910;

public class Solution
{
    // 문자열의 뒤의 n글자: https://school.programmers.co.kr/learn/courses/30/lessons/181910
    public string solution(string my_string, int n)
    {
        string answer = "";

        int startIndex = my_string.Length - n;
        int endIndex = my_string.Length;
        answer = my_string[startIndex..endIndex];

        return answer;
    }
}
