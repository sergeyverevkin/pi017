using System;
using System.Collections.Generic;
using System.Linq;

namespace pi172_181020_ClassLibrary
{

  /*
   *
   * Библиотека:
   *  - название
   *  - адрес
   *  - книга[]
   *
   * Книга:
   *  - жанр
   *  - заглавие
   *  - автор[]
   *  - год издания
   *
   */

  /// <summary>
  /// Класс библиотеки
  /// </summary>
  public class CLibrary
  {
    /// <summary>
    /// Идентификатор очередной новой книги
    /// </summary>
    private int m_iBookId = 1;

    #region public properties

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Книги
    /// </summary>
    private List<CBook> Books { get; set; }

    /// <summary>
    /// Справочник всех авторов
    /// </summary>
    public CAuthorList RefAuthor
    {
      get;
      private set;
    }

    #endregion

    #region constructors

    /// <summary>
    /// Конструктор
    /// </summary>
    public CLibrary()
    {
      RefAuthor = new CAuthorList();
      RefAuthor.Load();
      Books = new List<CBook>();
      // Books.Load("books.xml");
      h_AssignMaxBookId();

    }
    #endregion


    #region private method
    private void h_AssignMaxBookId()
    {
      int iMax = 0;
      foreach (CBook pBook in Books)
      {
        if (pBook.Id > iMax)
        {
          iMax = pBook.Id;
        }
      }
      m_iBookId = iMax; // + 1;
    }
    #endregion

    #region public methods

    /// <summary>
    /// Заполнение библиотеки тестовыми книгами
    /// </summary>
    public void FillLibrary()
    {
      // очистку библиотеки
      Books.Clear();
      // создал автора
      CAuthor pAuthor = new CAuthor(1, "Гоголь", "Николай", "Васильевич",
        new DateTime(1800, 1, 1));
      // добавил книгу №1
      AddBook(EGenre.Criminal, "Темные ночи", 2016,
        new List<CAuthor>() { pAuthor });
      // ..
      AddBook(EGenre.Criminal, "Темные ночи-2", 2014,
        new List<CAuthor>() { pAuthor });
      AddBook(EGenre.Criminal, "Темные ночи-1", 2015,
        new List<CAuthor>() { pAuthor });
      AddBook(EGenre.Criminal, "Темные ночи+1", 2017,
        new List<CAuthor>() { pAuthor });
    }

    /// <summary>
    /// Удалить книгу из списка
    /// </summary>
    /// <param name="iId"></param>
    public void RemoveBook(int iId)
    {
      CBook pBook = GetBook(iId);
      if (pBook == null) return;
      Books.Remove(pBook);
    }

    /// <summary>
    /// Получение книги
    /// </summary>
    /// <param name="iId"></param>
    /// <returns></returns>
    public CBook GetBook(int iId)
    {
      foreach (CBook pBook in Books)
      {
        // TODO: 01.12.2018
        if (pBook.Year == iId)
        {
          return pBook;
        }
      }
      return null;
    }
    
    /// <summary>
    /// Добавление книги
    /// </summary>
    /// <param name="pBook"></param>
    public void AddBook(CBook pBook)
    {
      // присваивается "идентификатор книги" книге
      pBook.Id = m_iBookId++;
      // добавление книги в нашу коллекцию книг
      Books.Add(pBook);
    }

    /// <summary>
    /// Добавление
    /// </summary>
    /// <param name="enGenre"></param>
    /// <param name="sTitle"></param>
    /// <param name="iYear"></param>
    /// <param name="arAuthors"></param>
    public void AddBook(
      EGenre enGenre, 
      string sTitle, 
      int iYear,
      List<CAuthor> arAuthors
      )
    {
      // создание экземпляра книги
      CBook pBook = new CBook()
      {
        Genre = enGenre,
        Title = sTitle,
        Year = iYear,
      };
      // заполнение авторов
      foreach (CAuthor pA in arAuthors)
      {
        pBook.AuthorList.Add(pA);
      }
      AddBook(pBook);
    }


    /// <summary>
    /// Получение книг
    /// </summary>
    /// <returns></returns>
    public IEnumerable<CBook> GetBooks()
    {
      return Books;
    }
    #endregion

  }
}
