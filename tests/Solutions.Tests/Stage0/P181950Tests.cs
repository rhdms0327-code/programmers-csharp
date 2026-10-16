using Xunit;

public class P181950Tests
{
    [Theory]
    [InlineData("string 5", new[] { "stringstringstringstringstring" })]
    public void Examples(string input, string[] expects) =>
        Assert.Equal(expects, ConsoleRunner.RunLines(P181950.Example.Main, input));
}