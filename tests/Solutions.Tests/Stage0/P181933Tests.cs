using Xunit;

public class P181933Tests
{
    [Theory]
    [InlineData(-4, 7, true, 3)]
    [InlineData(-4, 7, false, -11)]
    public void Example1(int a, int b, bool flag, int expected) => Assert.Equal(expected, new P181933.Solution().solution(a, b, flag));
}