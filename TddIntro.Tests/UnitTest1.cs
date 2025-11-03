namespace TddIntro.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var a = 2;
        var b = 2;

        // Act
        var result = a + b;

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var a = 10;
        var b = 10;
        var expected = 100;

        // Act
        var result = a * b;

        // Assert
        Assert.Equal(expected, result);
    }
}
