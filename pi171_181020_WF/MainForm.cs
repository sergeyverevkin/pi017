using pi171_181020_Classes;
using System;
using System.Windows.Forms;

namespace pi171_181020_WF
{
  public partial class MainForm : Form
  {
    private CTheatre m_pTheatre;

    public MainForm()
    {
      InitializeComponent();
      h_Load();
      h_Refresh();
    }

    private void h_Refresh()
    {
      // запомнить индекс выбранной строки
      ListView.SelectedIndexCollection arSelected =
        lvPerfList.SelectedIndices;
      int iIndex = (arSelected.Count == 0) ? 0 : arSelected[0];
      //int iIndex;
      //if (lvPerfList.SelectedIndices.Count == 0)
      //{
      //  iIndex = 0;
      //}
      //else
      //{
      //  iIndex = lvPerfList.SelectedIndices[0];
      //}

      // очистить список
      lvPerfList.Items.Clear();
      int ii = 0;
      // последовательно заполнить список
      foreach (CPerformance pPerformance in
        m_pTheatre.GetPerformanceList())
      {
        ListViewItem pRow = lvPerfList.Items.Add((++ii).ToString());
        pRow.SubItems.Add(pPerformance.Title);
        pRow.SubItems.Add(pPerformance.Duration.ToString());
        pRow.SubItems.Add(pPerformance.AuthorListString);
        pRow.Tag = pPerformance.Id; // pPerformance;
      }
      // восстановить индекс выбранной строки
    }

    private void h_Load()
    {
      m_pTheatre = new CTheatre();
      m_pTheatre.Address = "Кемерово";
      m_pTheatre.Title = "Молодежный театр";
      m_pTheatre.TestFill();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      CPerformance pTheatrePerformance = h_GetSelectedByTag();
      if (pTheatrePerformance == null) return;
      using (PerformanceForm pForm =
        new PerformanceForm(pTheatrePerformance))
      {
        // открытие формы в диалоговом режиме
        DialogResult dr = pForm.ShowDialog();
        if (dr == DialogResult.OK)
        {
          // при нажатии на ОК 
          //  - обновить список
          h_Refresh();
        }
      }
    }

    //private CPerformance h_GetSelected()
    //{
    //  ListView.SelectedIndexCollection arSelected =
    //    lvPerfList.SelectedIndices;
    //  if (arSelected.Count == 0) return null;
    //  int iIndex = arSelected[0];
    //  return m_pTheatre.PerformanceList[iIndex];
    //}

    private CPerformance h_GetSelectedByTag()
    {
      ListView.SelectedListViewItemCollection ar =
        lvPerfList.SelectedItems;
      if (ar.Count == 0) return null;
      ListViewItem pRow = ar[0];
      // return pRow.Tag as CPerformance;
      int iId = (int)(pRow.Tag);
      return m_pTheatre.GetPerformance(iId);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      // Создание объекта представления
      CPerformance pTheatrePerformance =
        new CPerformance(
        "Название",
        10,
        "Фамилия И.О.",
        null);
      // создание формы с созданным объектом
      using (PerformanceForm pForm =
        new PerformanceForm(pTheatrePerformance))
      {
        // открытие формы в диалоговом режиме
        DialogResult dr = pForm.ShowDialog();
        if (dr == DialogResult.OK)
        {
          // при нажатии на ОК 
          //  - добавление представления в список
          m_pTheatre.AddPerformance(pTheatrePerformance);
          //  - обновить список
          h_Refresh();
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      CPerformance pT =
        h_GetSelectedByTag();
      if (pT == null) return;
      string sMsg =
        $"Уверены, что хотите удалить {pT.Title}?";
      DialogResult dr = MessageBox.Show(
        sMsg, "Вопрос", MessageBoxButtons.YesNo);
      if (dr == DialogResult.No) return;
      try
      {
        m_pTheatre.RemovePerformance(pT.Id);
      }
      catch (Exception pE)
      {
        MessageBox.Show(
          $"Ошибка удаления: {pE.Message}");
      }

      // m_pTheatre.PerformanceList.Remove(pT);
      h_Refresh();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // создание формы с созданным объектом
      using (AuthorListForm pForm =
        new AuthorListForm(m_pTheatre.GetAuthorList()))
      {
        pForm.ShowDialog();
      }
    }

  }
}
