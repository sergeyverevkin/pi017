namespace TooHotApp.Classes
{
  public enum EAccuracy
  {
    /// <summary>
    /// Зарезервировано
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// Самая низкая точность
    /// </summary>
    Cold = 1,
    /// <summary>
    /// Немного близко
    /// </summary>
    Hot = 2,
    /// <summary>
    /// Самая близкая к значению
    /// </summary>
    Hotter = 3,
    /// <summary>
    /// Соответствует значению
    /// </summary>
    Correct = 4
  }
}