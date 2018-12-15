using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pi172_181020_ClassLibrary;

namespace pi172_181020_WF
{
  public partial class MainForm : Form
  {
    /// <summary>
    /// Поле "Библиотека"
    /// </summary>
    private CLibrary m_pLibrary;

    /// <summary>
    /// Конструктор формы
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      h_Load();
    }

    /// <summary>
    /// Метод по загрузке библиотеки
    /// </summary>
    private void h_Load()
    {
      m_pLibrary = new CLibrary()
      {
        Address = "гор. Кемерово, ул. Весенняя, 9",
        Title = "Юношеская бибилиотека им. Н.В. Гоголя"
      };

      this.Text = m_pLibrary.Title;

      m_pLibrary.FillLibrary();
      h_RefreshLibrary();
    }

    private void h_RefreshLibrary()
    {
      // запомнить выбранную позицию
      //int iPosition;
      //if (lvBooks.SelectedIndices.Count == 0)
      //{
      //  iPosition = lvBooks.SelectedIndices.Count;
      //} else
      //{
      //  iPosition = 0;
      //}
      int iCount = lvBooks.SelectedIndices.Count;
      int iPosition = (iCount == 0) ? iCount : 0;
      // очистить список
      lvBooks.Items.Clear();
      // заполнить каждой книгой
      int ii = 0;
      foreach (CBook pBook in m_pLibrary.GetBooks())
      {
        // 1-ая колонка
        ListViewItem pItem = lvBooks.Items.Add((++ii).ToString());
        // 2-ая колонка
        pItem.SubItems.Add(pBook.Title);
        pItem.SubItems.Add(pBook.Year.ToString());
        IEnumerable<string> ar = pBook.AuthorList
          .Select(p => 
            $"{p.Surname} {p.Firstname} {p.Middlename}"
          );
        pItem.SubItems.Add(String.Join(", ", ar));
        // TODO: 01.12.2018: 
        // добавить Id в книгу, 
        // удалять и редактировать по Id
        pItem.Tag = pBook.Id;
      }
      // восстановить выбранную позицию
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      // 1. создать экземпляр книги
      CBook pBook = new CBook();
      pBook.Title = "Новая книга";
      pBook.Year = 2000;
      // 2. открыть форму для "редактирования" экземпляра книги
      using (BookForm pBookForm = new BookForm(pBook))
      {
        DialogResult dr = pBookForm.ShowDialog();
        // добавить книгу в список при "ОК"
        if (dr == DialogResult.OK)
        {
          m_pLibrary.AddBook(pBook);
          // обновить форму
          h_RefreshLibrary();
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      CBook pBook = h_GetSelectedBook2();
      if (pBook == null) return;
      // 2. открыть форму для "редактирования" экземпляра книги
      using (BookForm pBookForm = new BookForm(pBook))
      {
        DialogResult dr = pBookForm.ShowDialog();
        if (dr == DialogResult.OK)
        {
          // обновить форму
          h_RefreshLibrary();
        }
      }
    }

    //private CBook h_GetSelectedBook()
    //{
    //  if (lvBooks.SelectedIndices.Count == 0)
    //  {
    //    return null;
    //  }
    //  int iIndex = lvBooks.SelectedIndices[0];
    //  CBook pBook = m_pLibrary.Books[iIndex];
    //  return pBook;
    //}

    private CBook h_GetSelectedBook2()
    {
      if (lvBooks.SelectedItems.Count == 0)
      {
        return null;
      }
      ListViewItem pRow = lvBooks.SelectedItems[0];
      int iId = (int)pRow.Tag;
      CBook pBook = m_pLibrary.GetBook(iId); 
      return pBook;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      CBook pBook = h_GetSelectedBook2();
      if (pBook == null) return;
      string sMsg = $@"Вы уверены, 
что хотите удалить книгу {pBook.Title}";
      DialogResult dr = MessageBox.Show(
        sMsg,
        "Вопрос",
        MessageBoxButtons.YesNo);
      if (dr == DialogResult.No) return;
      m_pLibrary.RemoveBook(pBook.Id);
      h_RefreshLibrary();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // TODO: передать список авторов
      // открыть форму
      using (RefAuthorListForm pBookForm = 
        new RefAuthorListForm())
      {
        pBookForm.ShowDialog();
      }
    }
  }
}
