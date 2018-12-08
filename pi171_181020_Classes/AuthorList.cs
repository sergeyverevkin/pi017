using System;
using System.Collections.Generic;

namespace pi171_181020_Classes
{
  /// <summary>
  /// Типизированный список авторов
  /// </summary>
  public class CAuthorList: List<CAuthor>
  {
    private int m_iAutoIncrement = 1;

    /// <summary>
    /// Добавить новое представление с 
    /// присвоением идентификатора
    /// </summary>
    /// <param name="pP"></param>
    /// <returns></returns>
    public int AddAuthor(CAuthor pP)
    {
      pP.Id = m_iAutoIncrement++;
      this.Add(pP);
      return pP.Id;
    }

    public CAuthor Get(int iId)
    {
      foreach (CAuthor pP in this)
      {
        if (pP.Id == iId)
        {
          return pP;
        }
      }

      return null;
    }

    public void Delete(int iId)
    {
      if (this.Count == 1)
      {
        throw new Exception(
          "Нельзя удалять последнего автора!");
      }
      CAuthor pP = this.Get(iId);
      if (pP == null)
      {
        throw new Exception(
          $"Не найдено автора (id={iId})");
      }
      this.Remove(pP);
    }
  }
}
