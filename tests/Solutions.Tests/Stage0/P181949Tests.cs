using Xunit;

public class P181949Tests
{
    [Theory]
    [InlineData("aBcDeFg", new[] { "AbCdEfG" })]
    public void Examples(string input, string[] expects) =>
        Assert.Equal(expects, ConsoleRunner.RunLines(P181949.Example.Main, input));
}