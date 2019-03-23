﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz.Classes.Model
{
  public class CQuestion
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="id"></param>
    /// <param name="text"></param>
    /// <param name="level"></param>
    public CQuestion(
      int id, 
      string text, 
      int level)
    {
      Id = id;
      Text = text;
      Level = level;

      AnswerList = new List<CAnswer>();
      CategoryList = new List<CCategory>();
    }

    /// <summary>
    /// .ctor
    /// </summary>
    private CQuestion()
    {

    }

    /*
- идентификатор (автоинкремент)
- текст: строка
- сложность: число
- [private] правильный ответ[]
- категория[]
- ПравильныйОтветЛи(вариант ответа: строка)
   проходить по всем правильным ответам и 
   вызывать их ПравильныйОтветЛи()
   */
    public int Id { get; set; }
    public string Text { get; set; }
    public int Level { get; set; }
    private List<CAnswer> AnswerList { get; set; }
    [XmlIgnore]
    public List<CCategory> CategoryList { get; private set; }
    [XmlArray]
    public List<int> CategoryId => 
      CategoryList.Select(p => p.Id).ToList();

    /// <summary>
    /// Правильный ответ ли
    /// </summary>
    /// <param name="sText"></param>
    /// <returns></returns>
    public bool WhetherAnswerIsCorrect(string sText)
    {
      foreach(CAnswer pA in AnswerList) {
        if (pA.WhetherAnswerIsCorrect(sText)) return true;
      }
      return false;
    }
  }
  /// <summary>
  /// 
  /// </summary>
  public class CQuestionList : List<CQuestion>
  {

  }
}
