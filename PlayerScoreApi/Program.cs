var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

// We need this to use the API in tests
// It makes this program available for introspection
// by other projects.
public partial class Program { }
