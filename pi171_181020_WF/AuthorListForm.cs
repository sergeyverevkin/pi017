using System;
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

    #region private methods

    private void h_RefreshView()
    {
      lvAuthorList.Items.Clear();
      foreach (CAuthor pAuthor in m_pList)
      {
        ListViewItem pItem = 
          lvAuthorList.Items.Add(
            pAuthor.Id.ToString());
        pItem.SubItems.Add(
          pAuthor.GetFioShort());
        pItem.SubItems.Add(
          pAuthor.Birthdate.ToString());
        pItem.Tag = pAuthor.Id;
      }
    }

    private CAuthor h_GetSelectedByTag()
    {
      ListView.SelectedListViewItemCollection ar =
        lvAuthorList.SelectedItems;
      if (ar.Count == 0) return null;
      ListViewItem pRow = ar[0];
      // return pRow.Tag as CPerformance;
      int iId = (int)(pRow.Tag);
      return m_pList.Get(iId);
    }


    #endregion

    #region handlers

    private void btnDelete_Click(object sender, EventArgs e)
    {
      CAuthor pT = h_GetSelectedByTag();
      if (pT == null) return;
      string sMsg =
        $"Уверены, что хотите удалить {pT.GetFioShort()}?";
      DialogResult dr = MessageBox.Show(
        sMsg, "Вопрос", MessageBoxButtons.YesNo);
      if (dr == DialogResult.No) return;
      try
      {
        m_pList.Delete(pT.Id);
      }
      catch (Exception pE)
      {
        MessageBox.Show(
          $"Ошибка удаления: {pE.Message}");
      }
      h_RefreshView();
    }

    #endregion
  }
}
