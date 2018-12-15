using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi172_181020_ClassLibrary
{
  /// <summary>
  /// Автор произведения:
  ///  - Фамилия, имя, отчество
  ///  - дата рождения
  /// </summary>
  public class CAuthor
  {
    /// <summary>
    /// Конструктор класса "Автор"
    /// </summary>
    /// <param name="iId">Идентификатор в "БД"</param>
    /// <param name="sSurname">фамилия</param>
    /// <param name="sName">имя</param>
    /// <param name="sMiddleName">отчество</param>
    /// <param name="dtBirthdate">дата рождения</param>
    public CAuthor(
      int iId,
      string sSurname, 
      string sName, 
      string sMiddleName, 
      DateTime dtBirthdate)
    {
      Id = iId;
      Surname = sSurname;
      Middlename = sMiddleName;
      Firstname = sName;
      Birthdate = dtBirthdate;
    }

    #region public properties

    /// <summary>
    /// фамилия
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// отчество
    /// </summary>
    public string Middlename { get; set; }
    /// <summary>
    /// имя
    /// </summary>
    public string Firstname { get; set; }
    /// <summary>
    /// дата рождения автора
    /// </summary>
    public DateTime Birthdate { get; set; }
    
    /// <summary>
    /// Идентификатор автора
    /// </summary>
    public int Id { get; set; }

    #endregion

    #region public methods

    /// <summary>
    /// Копирование данных из переданного объекта
    /// </summary>
    /// <param name="pAuthor"></param>
    public void CopyFrom(CAuthor pAuthor)
    {
      this.Birthdate = pAuthor.Birthdate;
      this.Firstname = pAuthor.Firstname;
      this.Middlename = pAuthor.Middlename;
      this.Surname = pAuthor.Surname;
    }
    #endregion
  }
}
