using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost4.Classes
{
  public class CTask
  {
    /// <summary>
    /// Категория трех из четырех
    /// </summary>
    CCategory AnswerCategory { get; set; }

    /// <summary>
    /// Список картинок на задании
    /// </summary>
    CPicture[] PictureList = new CPicture[4];

    internal bool IsAnswerCorrect(int iPictureId)
    {
      // получаете картинку по id
      // проверяете, что у нее нет AnswerCategory
      return true;
    }
  }
}
