using System.ComponentModel.DataAnnotations;

public class ScoreModel
{
  [Key]
  public required string playeralias { get; set; }
  public required int score { get; set; }
}
