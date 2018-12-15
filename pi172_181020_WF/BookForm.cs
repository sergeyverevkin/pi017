using System;
using System.Windows.Forms;
using pi172_181020_ClassLibrary;

namespace pi172_181020_WF
{
  public partial class BookForm : Form
  {
    // TODO: 17.11.2018: добавить на форму поля книги
    private CBook m_pBook;
    private CBook m_pInitBook;

    public BookForm(CBook pBook)
    {
      InitializeComponent();
      m_pBook = pBook;

      m_pInitBook = new CBook();
      m_pInitBook.CopyFrom(m_pBook);
      // m_pBook.CopyTo(m_pInitBook);

      nupYear.Maximum = DateTime.Now.Year;
      h_FillToForm();
    }

    private void h_FillToForm()
    {
      Text = $"Книга [{m_pBook.Title}]";
      edTitle.Text = m_pBook.Title;
      nupYear.Value = m_pBook.Year;
    }

    private void h_FillFromForm()
    {
      m_pBook.Title = edTitle.Text;
      decimal pV = nupYear.Value;
      m_pBook.Year = (int)pV;// Convert.ToInt32(nupYear.Value); // Int32.Parse()
      // ....
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
      h_FillFromForm();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      m_pBook.CopyFrom(m_pInitBook);
    }
  }
}
