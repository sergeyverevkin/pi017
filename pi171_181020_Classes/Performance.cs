using System;
using System.Collections.Generic;
using System.Linq;

namespace pi171_181020_Classes
{
  /*
   * Театр:
   *  - название
   *  - адрес
   *  - спектакль[]
   *
   * Спектакль:
   *  - название
   *  - актеры
   *  - продолжительность
   *  - автор[]
   *  - режиссер
   *
   */

  /// <summary>
  /// Представление театра
  /// </summary>
  public class CPerformance
  {
    //* Спектакль:
    //*  - название
    //*  - продолжительность
    //*  - автор[]
    //*  - режиссер

    /// <summary>
    /// Идентификатор записи "спектакль"
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// название
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// продолжительность, мин
    /// </summary>
    public int Duration { get; set; }
    /// <summary>
    /// Режиссер, ФИО
    /// </summary>
    public string Producer { get; set; }
    /// <summary>
    /// Авторы
    /// </summary>
    public List<CAuthor> AuthorList { get; private set; }

    /// <summary>
    /// Список авторов в виде строки, разделенной запятыми
    /// </summary>
    public string AuthorListString
    {
      get
      {
        //string s = "";
        //foreach (CAuthor pAuthor in AuthorList)
        //{
        //  if (!String.IsNullOrEmpty(s)) { s += ", "; }
        //  s += pAuthor.GetFioShort();
        //}

        // -
        IEnumerable<string> ar = AuthorList.Select(p => 
          p.GetFioShort());
        return String.Join(", ", ar);

        //return String.Join(", ", 
        //  AuthorList.Select( p=> p.GetFioShort())
        //);
      }
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sTitle">Название произведения</param>
    /// <param name="iDuration">Продолжительность, мин</param>
    /// <param name="sProducer">Режиссер</param>
    /// <param name="pAuthor">Автор произведения</param>
    public CPerformance(
      string sTitle, 
      int iDuration, 
      string sProducer,
      CAuthor pAuthor)
    {
      Title = sTitle;
      Duration = iDuration;
      Producer = sProducer;
      AuthorList = new List<CAuthor>();
      if (pAuthor != null)
      {
        AuthorList.Add(pAuthor);
      }
    }
  }
}
