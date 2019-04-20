using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooHotApp.Classes
{
  public class CGame
  {
    private Random m_pRandom = new Random();

    /// <summary>
    /// Загаданные цифры
    /// </summary>
    public List<CDigit> Digits { get; private set; }

    /// <summary>
    /// Количество ходов
    /// </summary>
    public int TurnCount;

    public CGame()
    {
      Digits = new List<CDigit>();
    }

    /// <summary>
    /// Создать случайное число
    /// </summary>
    public void New(int iDigitCount)
    {
      TurnCount = 0;
      for (int ii = 0; ii < iDigitCount; ii++)
      {
        CDigit pDigit = new CDigit();
        pDigit.Value = m_pRandom.Next(0, 10);
        Digits.Add(pDigit);
      }
    }    

  }
}
