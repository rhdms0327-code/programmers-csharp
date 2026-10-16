using Microsoft.VisualBasic;
using Xunit;
using System;

public class P181952Tests
{
    [Theory]
    [InlineData("HelloWorld!")]
    public void Examples(string input) =>
        Assert.Equal(new[] { input }, ConsoleRunner.RunLines(P181952.Example.Main, input));
}