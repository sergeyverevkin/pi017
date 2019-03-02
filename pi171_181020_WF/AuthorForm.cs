using pi171_181020_Classes;
using System.Windows.Forms;

namespace pi171_181020_WF
{
  public partial class AuthorForm : Form
  {
    private CAuthor m_pAuthor;
    public AuthorForm(CAuthor pAuthor)
    {
      InitializeComponent();
      m_pAuthor = pAuthor;
      h_FillToForm();
    }

    private void h_FillToForm()
    {
      txtFirstName.Text = m_pAuthor.Firstname;
      txtMiddleName.Text = m_pAuthor.Middlename;
      txtSurname.Text = m_pAuthor.Surname;
      dtpBirthDate.Value =
        m_pAuthor.Birthdate.AsDate();
    }
    private void h_FillFromForm()
    {
      m_pAuthor.Firstname = txtFirstName.Text;
      m_pAuthor.Middlename = txtMiddleName.Text;
      m_pAuthor.Surname = txtSurname.Text;
      m_pAuthor.Birthdate = 
        new CBirthDate(dtpBirthDate.Value);
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
      h_FillFromForm();
    }

    private void btnReset_Click(object sender, System.EventArgs e)
    {
      h_FillToForm();
    }

    private void AuthorForm_Load(object sender, System.EventArgs e)
    {

    }
  }
}
