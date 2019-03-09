using System.Collections.Generic;

namespace Quiz.Classes.Model
{
  public class CGameField
  {
    /// <summary>
    /// .ctor
    /// </summary>
    public CGameField()
    {
      GameCategory = new List<CGameCategory>();
    }

    /// <summary>
    /// Список категорий
    /// </summary>
    public List<CGameCategory> GameCategory { get; set; }
  }
}