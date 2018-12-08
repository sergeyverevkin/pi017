using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi171_181020_Classes
{
  /// <summary>
  /// Типизированный список представлений
  /// </summary>
  public class CPerformanceList: List<CPerformance>
  {
    private int m_iAutoIncrement = 1;

    /// <summary>
    /// Добавить новое представление с 
    /// присвоением идентификатора
    /// </summary>
    /// <param name="pP"></param>
    /// <returns></returns>
    public int AddPerformance(CPerformance pP)
    {
      pP.Id = m_iAutoIncrement++;
      this.Add(pP);
      return pP.Id;
    }

    public CPerformance Get(int iId)
    {
      foreach (CPerformance pP in this)
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
          "Нельзя удалять последнее представление!");
      }
      CPerformance pP = this.Get(iId);
      if (pP == null)
      {
        throw new Exception(
          $"Не найдено представление (id={iId})");
      }
      this.Remove(pP);
    }
  }
}
