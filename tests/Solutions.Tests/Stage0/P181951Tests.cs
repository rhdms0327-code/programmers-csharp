using Xunit;

public class P181951Tests
{
    [Theory]
    [InlineData("4 5", new[] { "a = 4", "b = 5" })]
    public void Examples(string input, string[] expects) =>
        Assert.Equal(expects, ConsoleRunner.RunLines(P181951.Example.Main, input));
}