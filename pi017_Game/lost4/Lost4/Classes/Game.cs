using System.Collections.Generic;

namespace Lost4.Classes
{
  /// <summary>
  /// Игра четвертый лишний
  /// </summary>
  public class CGame
  {

    /// <summary>
    /// Текущее задание игрока
    /// </summary>
    public CTask CurrentTask { get; set; }
    /// <summary>
    /// Количество очков у игрока
    /// </summary>
    public int Score { get; set; }
    public List<CCategory> DbCategory { get; set; }
    public List<CPicture> DbPicture { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public CGame()
    {
      DbCategory = new List<CCategory>();
      DbPicture = new List<CPicture>();
    }


    /// <summary>
    /// Формирует следующее задание
    /// </summary>
    public void Next()
    {
    }
    /// <summary>
    /// Выбор ответа
    /// </summary>
    public bool SetAnswer(int iPictureId)
    {
      bool bCorrect =
        CurrentTask.IsAnswerCorrect(iPictureId);

      if (bCorrect) {
        Score += 1;
      }
      return bCorrect;
    }
  }
}
