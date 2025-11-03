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
}
