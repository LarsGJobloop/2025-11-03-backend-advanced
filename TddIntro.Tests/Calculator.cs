namespace TddIntro.Tests;

public class Calculator_Specification
{
    [Fact]
    public void ThereExistsACalculatorClass()
    {
        // Arrange & Act
        var calculator = new Calculator.Calculator();

        // Assert
        Assert.NotNull(calculator);
    }

    [Fact]
    public void AddMethod_AddNumbers_Correctly()
    {
        // Arrange
        var a = 3;
        var b = 3;
        var expected = 6;

        var calculator = new Calculator.Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
