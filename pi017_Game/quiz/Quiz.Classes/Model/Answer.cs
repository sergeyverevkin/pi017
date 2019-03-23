using System;

namespace Quiz.Classes.Model
{
  public class CAnswer
  {
    /*
    - текст
    - ПравильныйОтветЛи(вариантОтвета: строка)
     */
     /// <summary>
     /// Текст варианта ответа
     /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Правильный ли ответ
    /// </summary>
    /// <param name="sText"></param>
    /// <returns></returns>
    public bool WhetherAnswerIsCorrect(string sText)
    {
      return this.Text.Equals(sText, StringComparison.InvariantCultureIgnoreCase);
    }
  }
}