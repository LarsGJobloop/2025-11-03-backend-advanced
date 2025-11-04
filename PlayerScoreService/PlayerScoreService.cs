namespace PlayerScoreService;

public class PlayerScoreService
{
  Dictionary<string, int> _score;

  public PlayerScoreService()
  {
    _score = new Dictionary<string, int>();
  }

  public int? GetScore(string playerAlias)
  {
    var isRegistered = _score.TryGetValue(playerAlias, out int result);

    if (isRegistered)
    {
      return result;
    }
    else
    {
      return null;
    }

  }

  public void Add(string playerAlias, int score)
  {
    var isRegistered = _score.TryGetValue(playerAlias, out int oldScore);

    if (isRegistered)
    {
      _score[playerAlias] += score;
    }
    else
    {
      _score.Add(playerAlias, score);
    }
  }
}
