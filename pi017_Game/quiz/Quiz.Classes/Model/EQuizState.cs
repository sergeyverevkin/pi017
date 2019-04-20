namespace Quiz.Classes.Model
{
  /// <summary>
  /// Состояние игры
  /// </summary>
  public enum EQuizState
  {
    /// <summary>
    /// Зарезервировано
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// Выбор категории и цены (вопроса)
    /// </summary>
    ChooseQuestion = 1,
    /// <summary>
    /// Выбор игрока
    /// </summary>
    ChoosePlayer = 2,
    /// <summary>
    /// Ввод ответа
    /// </summary>
    SetAnswer = 3,
    /// <summary>
    /// Игра окончена
    /// </summary>
    EndOfGame = 4,
    /// <summary>
    /// Приложение стартовало, доступна только "новая игра"
    /// </summary>
    StartApplication = 5,

  }
}