using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pi171_181020_Classes;

namespace pi171_181020_WF
{
  public partial class AuthorListForm : Form
  {
    private CAuthorList m_pList;
    public AuthorListForm(CAuthorList pList)
    {
      InitializeComponent();
      m_pList = pList;
      h_RefreshView();
    }

    private void h_RefreshView()
    {
      lvAuthorList.Items.Clear();
      foreach (CAuthor pAuthor in m_pList)
      {
        // TODO: 01.12.2018 - заполнить ListView
      }
    }
  }
}
