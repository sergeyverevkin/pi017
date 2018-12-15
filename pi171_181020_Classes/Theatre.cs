using System.Collections.Generic;

namespace pi171_181020_Classes
{
  /// <summary>
  /// Театр
  /// </summary>
  public class CTheatre
  {
    //* Театр:
    //*  - название
    //*  - адрес
    //*  - спектакль[]
    //*  - автор[]

    /// <summary>
    /// название
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; }

    private readonly CPerformanceList _performanceList = new CPerformanceList();

    /// <summary>
    /// Список представлений 
    /// </summary>
    internal CPerformanceList PerformanceList
    {
      get { return _performanceList; }
    }


    private readonly CAuthorList _authorList = 
      new CAuthorList();

    /// <summary>
    /// Список авторов
    /// </summary>
    internal CAuthorList AuthorList
    {
      get { return _authorList; }
    }


    public void TestFill()
    {
      CAuthor pAuthor1 = new CAuthor(
        "Толстой", "Лев", "Николаевич", 1900, 01, 20);
      CAuthor pAuthor2 = new CAuthor(
        "Достоевский", "Федор", "Михайлович", 1860, 04, 10);

      AuthorList.AddAuthor(pAuthor1);
      AuthorList.AddAuthor(pAuthor2);

      CPerformance pPerformance1 = new CPerformance(
        "Начало",
        10,
        "Иванов С.А.",
        pAuthor1);
      CPerformance pPerformance2 = new CPerformance(
        "Окончание",
        20,
        "Ложкин С.А.",
        pAuthor2);
      AddPerformance(pPerformance1);
      // PerformanceList.Add(pPerformance1);
      AddPerformance(pPerformance2);
      // PerformanceList.Add(pPerformance2);
    }

    /// <summary>
    /// Получение спекталя по id
    /// </summary>
    /// <param name="iId"></param>
    /// <returns></returns>
    public CPerformance GetPerformance(int iId)
    {
      return PerformanceList.Get(iId);
    }

    public void RemovePerformance(int iId)
    {
      PerformanceList.Delete(iId);
      // PerformanceList.Remove(GetPerformance(iId));
    }

    public void AddPerformance(CPerformance pTp)
    {
      PerformanceList.AddPerformance(pTp);
    }

    public IEnumerable<CPerformance> GetPerformanceList()
    {
      return PerformanceList;
    }

    /// <summary>
    /// Получение списка авторов
    /// </summary>
    /// <returns></returns>
    public CAuthorList GetAuthorList()
    {
      return AuthorList;
    }
  }
}
