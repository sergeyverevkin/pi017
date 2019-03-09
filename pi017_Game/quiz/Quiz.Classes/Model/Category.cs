namespace Quiz.Classes.Model
{
  public class CCategory
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="id"></param>
    /// <param name="text"></param>
    public CCategory(int id, string text)
    {
      Id = id;
      Text = text;
    }

    /*    - название
- идентификатор
*/

    public int Id { get; set; }
    public string Text { get; set; }
  }
}