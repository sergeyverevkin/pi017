using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi172_181020_ClassLibrary
{
  /// <summary>
  /// Специализированный список авторов (для справочника)
  /// </summary>
  public class CAuthorList: List<CAuthor>
  {
    #region private variables
    private int m_iMaxId = 0;
    #endregion

    #region private methods
    /// <summary>
    /// Запрос нового идентификатора для автора
    /// </summary>
    /// <returns></returns>
    private int h_GetNewId()
    {
      return ++m_iMaxId;
    }
    

    #endregion

    #region public methods

    /// <summary>
    /// "Загрузка" авторов
    /// </summary>
    /// <returns></returns>
    public int Load()
    {
      CAuthor pAuthor1 = new CAuthor(
        h_GetNewId(),
        "Гоголь", "Николай", "Васильевич",
        new DateTime(1800, 1, 1));

      CAuthor pAuthor2 = new CAuthor(
        h_GetNewId(),
        "Пушкин", "Александр", "Сергеевич",
        new DateTime(1799, 6, 6));

      this.Add(pAuthor1);
      this.Add(pAuthor2);

      return this.Count;
    }
    
    /// <summary>
    /// Сохранение автора
    /// </summary>
    /// <param name="pAuthor"></param>
    /// <returns></returns>
    public int Save(CAuthor pAuthor)
    {
      if (pAuthor.Id > 0)
      {
        // обновление записи
        CAuthor pA = GetAuthor(pAuthor.Id);
        pA.CopyFrom(pAuthor);
      }
      else
      {
        // добавление новой записи
        pAuthor.Id = h_GetNewId();
        this.Add(pAuthor);
      }

      return pAuthor.Id;
    }

    /// <summary>
    /// Получение автора по идентификатору
    /// </summary>
    /// <param name="iAuthorId"></param>
    /// <returns>Найденный автор по идентификатору или null, если автор не найден</returns>
    public CAuthor GetAuthor(int iAuthorId)
    {
      foreach (CAuthor p in this)
      {
        if (p.Id == iAuthorId) return p;
      }

      return null;
    }


    #endregion
  }
}
