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
}
