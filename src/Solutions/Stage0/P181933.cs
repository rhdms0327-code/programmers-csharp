using System;
using System.Collections.Generic;
using System.Linq;

namespace P181933;

public class Solution
{
    // flag에 따라 다른 값 반환하기: https://school.programmers.co.kr/learn/courses/30/lessons/181933
    public int solution(int a, int b, bool flag)
    {
        int answer = 0;

        if (flag)
        {
            answer = a + b;
        }
        else
        {
            answer = a - b;
        }

        return answer;
    }
}