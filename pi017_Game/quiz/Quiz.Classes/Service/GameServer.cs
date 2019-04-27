using Quiz.Classes.Model;
using System;

namespace Quiz.Classes.Service
{
  public class CGameServer : IGame
  {
    private DbQuiz m_pQuiz;
    private Random m_pRandom;
    /// <summary>
    /// .ctor
    /// </summary>
    public CGameServer()
    {
      m_pRandom = new Random();
      m_pQuiz = new DbQuiz();
      m_pQuiz.TestFill();
    }

    #region interface implementation

    /// <summary>
    /// Получить произвольный вопрос
    /// </summary>
    /// <returns></returns>
    public CQuestion GetQuestion()
    {
      int iCount = m_pQuiz.QuestionList.Count;
      int iQNum = m_pRandom.Next(0, iCount);
      return m_pQuiz.QuestionList[iQNum];
    }

    /// <summary>
    /// Получить список категорий
    /// </summary>
    /// <returns></returns>
    public CCategoryList GetCategoryList()
    {
      return m_pQuiz.CategoryList;
    }

    #endregion
  }
}