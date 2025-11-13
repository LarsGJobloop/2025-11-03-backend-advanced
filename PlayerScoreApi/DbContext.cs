using Microsoft.EntityFrameworkCore;

public class ScoreContext : DbContext
{
  public DbSet<ScoreModel> scores => Set<ScoreModel>();

  public ScoreContext(DbContextOptions<ScoreContext> opts)
    : base(opts) { }
}