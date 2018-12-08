using System;

namespace pi171_181020_Classes
{
  /// <summary>
  /// Дата рождения
  /// </summary>
  public class CBirthDate
  {
    #region private variables

    private DateTime m_dtBirthDate;

    #endregion

    #region public properties
    public int Year
    {
      get { return m_dtBirthDate.Year; }
      set
      {
        if (value > 1400)
        {
          m_dtBirthDate = new DateTime(
            value, m_dtBirthDate.Month, m_dtBirthDate.Day
          );
        }
      }
    }
    public int Month
    {
      get { return m_dtBirthDate.Month; }
      set
      {
        if (value < 13 && value > 0)
        {
          m_dtBirthDate = new DateTime(
            m_dtBirthDate.Year, value, m_dtBirthDate.Day
          );
        }
      }
    }
    public int Day
    {
      get { return m_dtBirthDate.Day; }
      set
      {
        if (value > 0 && value < 32)
        {
          m_dtBirthDate = new DateTime(
            m_dtBirthDate.Year, m_dtBirthDate.Month, value
          );
        }
      }
    }
    #endregion
    
    #region constructors

    public CBirthDate(DateTime dtBirthDate)
    {
      m_dtBirthDate = dtBirthDate;
    }
    public CBirthDate(int iYear, int iMonth, int iDay)
    {
      m_dtBirthDate = new DateTime(iYear, iMonth, iDay);
    }
    

    #endregion

    #region overrides

    /// <summary>Возвращает строку, представляющую текущий объект.</summary>
    /// <returns>Строка, представляющая текущий объект.</returns>
    /// <filterpriority>2</filterpriority>
    public override string ToString()
    {
      return m_dtBirthDate.ToString("yyyy");
    }

    #endregion
  }
}