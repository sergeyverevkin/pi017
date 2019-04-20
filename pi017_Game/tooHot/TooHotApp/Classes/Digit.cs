using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooHotApp.Classes
{
  public class CDigit
  {
    /// <summary>
    /// Правильное значение
    /// </summary>
    public int Value { get; set; }
    /// <summary>
    /// Значение, которое ввел пользователь
    /// </summary>
    public int? UserValue { get; set; }

    /// <summary>
    /// Точность угадывания пользователем
    /// </summary>
    public EAccuracy GetAccuracy()
    {
      if (!UserValue.HasValue)
      {
        return EAccuracy.Cold;
      }
      int iDelta = Math.Abs(Value - UserValue.Value);
      switch (iDelta) {
        case 0:
          return EAccuracy.Correct;
        case 1:
          return EAccuracy.Hotter;
        case 2:
        case 3:
          return EAccuracy.Hot;
        default:
          return EAccuracy.Cold;
      }
    }
  }
}
