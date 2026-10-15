using Xunit;

public class P42577Tests
{
    [Theory]
    [InlineData(new[] { "119", "97674223", "1195524421" }, false)]
    [InlineData(new[] { "123", "456", "789" }, true)]
    [InlineData(new[] { "12", "123", "1235", "567", "88" }, false)]
    public void Examples(string[] book, bool expected) =>
        Assert.Equal(expected, new P42577.Solution().solution(book));
}