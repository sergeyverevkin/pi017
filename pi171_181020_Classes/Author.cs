using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi171_181020_Classes
{
  /// <summary>
  /// Класс автора:
  ///  - Фамилия
  ///  - Имя
  ///  - Отчество
  ///  - Дата рождения
  /// </summary>
  public class CAuthor
  {
    /// <summary>
    /// Конструктор класса CAuthor
    /// </summary>
    /// <param name="sSurname"></param>
    /// <param name="sFirstname"></param>
    /// <param name="sMiddlename"></param>
    /// <param name="iYear"></param>
    /// <param name="iMonth"></param>
    /// <param name="iDay"></param>
    public CAuthor(
      string sSurname, string sFirstname, string sMiddlename,
      int iYear, int iMonth, int iDay
    )
    {
      Surname = sSurname;
      Firstname = sFirstname;
      Middlename = sMiddlename;
      Birthdate = new CBirthDate(iYear, iMonth, iDay);
    }

    /// <summary>
    /// Идентификатор автора
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string Firstname { get; set; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string Middlename { get; set; }
    /// <summary>
    /// Дата рождения
    /// </summary>
    public CBirthDate Birthdate { get; set; }
    
    /// <summary>
    /// Получает Фамилию И.О.
    /// </summary>
    /// <returns></returns>
    public string GetFioShort()
    {
      string sFN = Firstname.Substring(0, 1).ToUpperInvariant();
      string sMN = Middlename.Substring(0, 1).ToUpperInvariant();
      return $"{Surname} {sFN}.{sMN}.";
    }

  }
}
