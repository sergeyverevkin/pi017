using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pi172_181020_ClassLibrary;

namespace pi172_181020_WF
{
  public partial class RefAuthorListForm : Form
  {
    /// <summary>
    /// Поле "Список авторов"
    /// </summary>
    private CAuthorList m_pAuthorList;

    /// <summary>
    /// Конструктор формы
    /// </summary>
    public RefAuthorListForm()
    {
      InitializeComponent();
      h_Load();
    }

    /// <summary>
    /// Метод по загрузке 
    /// </summary>
    private void h_Load()
    {
      m_pAuthorList.Load();
      h_Refresh();
    }

    private void h_Refresh()
    {
      int iCount = lvBooks.SelectedIndices.Count;
      int iPosition = (iCount == 0) ? iCount : 0;
      // очистить список
      lvBooks.Items.Clear();
      // заполнить каждой книгой
      int ii = 0;
      foreach (CAuthor pAuthor in m_pAuthorList)
      {
        // 1-ая колонка
        ListViewItem pItem = lvBooks.Items.Add(
          pAuthor.Id.ToString());
        // 2-ая колонка
        pItem.SubItems.Add($"{pAuthor.Surname} {pAuthor.Firstname} {pAuthor.Middlename}");
        pItem.SubItems.Add(pAuthor.Birthdate.ToString());
        pItem.Tag = pAuthor.Id;
      }
      // восстановить выбранную позицию
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      // 1. создать экземпляр книги
      CAuthor pBook = new CAuthor(0, "","", "", DateTime.MinValue);
      //// 2. открыть форму для "редактирования" экземпляра книги
      //using (BookForm pBookForm = new BookForm(pBook))
      //{
      //  DialogResult dr = pBookForm.ShowDialog();
      //  // добавить книгу в список при "ОК"
      //  if (dr == DialogResult.OK)
      //  {
      //    m_pLibrary.AddBook(pBook);
      //    // обновить форму
      //    h_Refresh();
      //  }
      //}
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      //CBook pBook = h_GetSelectedBook2();
      //if (pBook == null) return;
      //// 2. открыть форму для "редактирования" экземпляра книги
      //using (BookForm pBookForm = new BookForm(pBook))
      //{
      //  DialogResult dr = pBookForm.ShowDialog();
      //  if (dr == DialogResult.OK)
      //  {
      //    // обновить форму
      //    h_Refresh();
      //  }
      //}
    }

    private CBook h_GetSelectedBook2()
    {
      return null;
      //if (lvBooks.SelectedItems.Count == 0)
      //{
      //  return null;
      //}
      //ListViewItem pRow = lvBooks.SelectedItems[0];
      //int iId = (int)pRow.Tag;
      //CBook pBook = m_pLibrary.GetBook(iId); 
      //return pBook;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
//      CBook pBook = h_GetSelectedBook2();
//      if (pBook == null) return;
//      string sMsg = $@"Вы уверены, 
//что хотите удалить книгу {pBook.Title}";
//      DialogResult dr = MessageBox.Show(
//        sMsg,
//        "Вопрос",
//        MessageBoxButtons.YesNo);
//      if (dr == DialogResult.No) return;
//      m_pLibrary.RemoveBook(pBook.Id);
//      h_Refresh();
    }
  }
}
