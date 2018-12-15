using System.Collections.Generic;

namespace pi172_181020_ClassLibrary
{
  /// <summary>
  /// Книга
  /// </summary>
  public class CBook
  {
    //* Книга:
    //*  - жанр
    //*  - заглавие
    //*  - автор[]
    //*  - год издания
    /// <summary>
    /// жанр
    /// </summary>
    public EGenre Genre { get; set; }
    /// <summary>
    /// заглавие
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// год издания
    /// </summary>
    public int Year { get; set; }
    /// <summary>
    /// Идентификатор записи
    /// </summary>
    public int Id { get; internal set; }

    private readonly List<CAuthor> _authorList = new List<CAuthor>();
    /// <summary>
    /// Список авторов
    /// </summary>
    public List<CAuthor> AuthorList
    {
      get { return _authorList; }
    }

    /// <summary>
    /// Копирует информацию из указанной книги в текущую книгу
    /// </summary>
    /// <param name="pBook"></param>
    public void CopyFrom(CBook pBook)
    {
      this.Title = pBook.Title;
      // TODO: 24.11.2018: добавить на форму поля книги
    }
  }
}
