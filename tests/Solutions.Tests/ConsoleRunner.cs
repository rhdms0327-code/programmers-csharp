using System;
using System.IO;

/// <summary>
/// 입출력형 문제(Main에서 Console로 읽고 쓰는 문제)를 테스트에서 실행하는 도우미.
/// 입력 문자열을 표준 입력으로 넣고 Main을 실행한 뒤, 출력된 내용을 문자열로 돌려준다.
/// 주의: 풀이에 Console.Clear()가 있으면 IOException이 나므로 로컬에서는 주석 처리한다.
/// </summary>
public static class ConsoleRunner
{
    // Console 입출력은 프로그램 전체가 공유하므로, 테스트가 동시에 실행돼도 섞이지 않게 한 번에 하나씩 실행한다.
    private static readonly object Gate = new();

    /// <summary>출력 전체를 그대로 돌려준다. 줄바꿈은 Environment.NewLine.</summary>
    public static string Run(Action main, string input = "")
    {
        lock (Gate)
        {
            var oldIn = Console.In;
            var oldOut = Console.Out;
            try
            {
                Console.SetIn(new StringReader(input));
                var output = new StringWriter();
                Console.SetOut(output);
                main();
                return output.ToString();
            }
            finally
            {
                Console.SetIn(oldIn);
                Console.SetOut(oldOut);
            }
        }
    }

    /// <summary>출력을 줄 단위 배열로 돌려준다. 마지막 줄바꿈 뒤의 빈 줄은 뺀다.</summary>
    public static string[] RunLines(Action main, string input = "")
    {
        var output = Run(main, input).Replace("\r\n", "\n");
        if (output.EndsWith("\n")) output = output[..^1];
        return output.Split('\n');
    }
}
