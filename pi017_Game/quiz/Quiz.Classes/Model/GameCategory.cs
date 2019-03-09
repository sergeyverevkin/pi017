using System.Collections.Generic;

namespace Quiz.Classes.Model
{
  public class CGameCategory
  {
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="category"></param>
    public CGameCategory(CCategory category)
    {
      Category = category;
    }

    /*
    - Категория;
- ИгровойВопрос[]

*/
    public CCategory Category { get; set; }
    public List<CGameQuestion> QuestionList { get; set; }

  }
}