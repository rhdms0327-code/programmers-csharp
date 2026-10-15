using Xunit;

public class P181850Tests
{
    [Theory]
    [InlineData(1.42, 1)]
    [InlineData(69.32, 69)]
    public void Examples(double flo, int expected) =>
        Assert.Equal(expected, new P181850.Solution().solution(flo));
}