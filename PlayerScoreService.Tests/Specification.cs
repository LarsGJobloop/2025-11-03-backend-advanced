namespace PlayerScoreService.Tests;

public class PlayerScoreServiceSpecification
{
    [Fact]
    public void Service_ShouldReturnNull_ForUnkownPlayers()
    {
        // Arrange
        var service = new PlayerScoreService();

        // Act
        var result = service.GetScore("Alice");

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Service_ShouldReturnCorrectScore_ForKnownPlayer()
    {
        // Arrange
        var service = new PlayerScoreService();

        // Act
        service.Add("Alice", 5);
        var result = service.GetScore("Alice");

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Service_ShouldSumScores_Correctly()
    {
        // Arrange
        var service = new PlayerScoreService();

        // Act
        service.Add("Alice", 5);
        service.Add("Alice", 5);
        var result = service.GetScore("Alice");

        // Assert
        Assert.Equal(10, result);
    }
}
