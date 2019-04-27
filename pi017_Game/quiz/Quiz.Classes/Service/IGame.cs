using Quiz.Classes.Model;
using System.ServiceModel;

namespace Quiz.Classes.Service
{
  /// <summary>
  /// Сервер игры
  /// </summary>
  [ServiceContract]
  public interface IGame
  {
    /// <summary>
    /// Получить произвольный вопрос
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    CQuestion GetQuestion();
    /// <summary>
    /// Получить список категорий
    /// </summary>
    /// <returns></returns>
    // [OperationContract]
    CCategoryList GetCategoryList();

  }
}
