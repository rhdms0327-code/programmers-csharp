using Xunit;

public class P181845Tests
{
    [Theory]
    [InlineData(123, "123")]
    [InlineData(2573, "2573")]

    public void Examples(int input, string result) =>
        Assert.Equal(result, new P181845.Solution().solution(input));
}