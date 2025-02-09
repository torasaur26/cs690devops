namespace FactorialService.Tests;
using FactorialLibrary;
using Xunit;

public class FactorialServiceTests
{
    [Fact]
    public void Test1()
    {
        var result = FactorialService.Factorial(0);
        Assert.Equal(1, result);
    }
}
