using Microsoft.AspNetCore.Mvc.Testing;

namespace PlayerScoreService.E2E;

// Testing a full Web server requires some setup
// In essence this imports the whole Web API server
// and wraps/mounts it into a Test class (Fixture)
// which allows us to probe and make assertion against
// the server more easily.
public class ApiEndToEndTests : IClassFixture<WebApplicationFactory<Program>>
{
    // We keep a persistent reference to the client here
    // meaning that every tests, inside this class
    // will be using the same Web API instance.
    private readonly HttpClient _client;

    public ApiEndToEndTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ScoreEndpointExists()
    {
        // Arrange
        // Act
        // Assert
    }
}
