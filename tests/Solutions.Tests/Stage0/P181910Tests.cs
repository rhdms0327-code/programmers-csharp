using Xunit;

public class P181910Tests
{
    [Theory]
    [InlineData("ProgrammerS123", 11, "grammerS123")]
    [InlineData("He110W0r1d", 5, "W0r1d")]
    public void Examples(string my_string, int n, string result) =>
        Assert.Equal(result, new P181910.Solution().solution(my_string, n));
}