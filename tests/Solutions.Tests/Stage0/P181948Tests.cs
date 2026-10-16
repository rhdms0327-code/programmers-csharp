using Xunit;

public class P181948Tests
{
    [Theory]
    [InlineData("""!@#$%^&*(\'"<>?:;""", new[] { """!@#$%^&*(\'"<>?:;""" })]
    public void Examples(string input, string[] expects) =>
        Assert.Equal(expects, ConsoleRunner.RunLines(P181948.Example.Main, input));
}