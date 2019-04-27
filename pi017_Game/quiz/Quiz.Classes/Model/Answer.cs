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
     /// Текст правильного варианта ответа
     /// </summary>
    public string CorrectAnswer { get; set; }
    /// <summary>
    /// Правильный ли ответ
    /// </summary>
    /// <param name="sText"></param>
    /// <returns></returns>
    public bool WhetherAnswerIsCorrect(string sText)
    {
      string sMyAnswer = this.CorrectAnswer;
      //return String.Equals(sMyAnswer, sText, StringComparison.InvariantCultureIgnoreCase);
      return sMyAnswer.Equals(sText, StringComparison.InvariantCultureIgnoreCase);
    }
  }
}