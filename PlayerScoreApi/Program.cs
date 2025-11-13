using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure DB Context, using the appsettings.json
builder.Services.AddDbContext<ScoreContext>(options =>
  options.UseNpgsql(
    builder.Configuration.GetConnectionString("Default")
  ));

var app = builder.Build();

app.MapGet("/score/{playerAlias}", (string playerAlias) =>
{
  return new { PlayerAlias = playerAlias };
});

app.Run();

// We need this to use the API in tests
// It makes this program available for introspection
// by other projects.
public partial class Program { }
