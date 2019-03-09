namespace Quiz.Classes.Model
{
  public class CGameQuestion
  {
    /*
      - баллы;
      - открыт/закрыт;
    */
    public int Score { get; set; }
    public bool HasAnswered { get; set; }
  }
  public class CSimpleGameQuestion: CGameQuestion
  {
    public int QuestionId;
  }
  public class CAnonymousGameQuestion : CGameQuestion
  {
    public int QuestionId;
  }
}