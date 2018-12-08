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
  public partial class PerformanceForm : Form
  {
    private CPerformance m_pPerformance;
    public PerformanceForm(CPerformance pPerformance)
    {
      InitializeComponent();
      m_pPerformance = pPerformance;
      h_FillToForm();
    }

    private void h_FillToForm()
    { 
      // TODO: 24.11.2018 / заполнить форму из объекта
      labTitle.Text = m_pPerformance.Title;
      nudDuration.Value = m_pPerformance.Duration;
    }
    private void h_FillFromForm()
    {
      // TODO: 24.11.2018 / заполнить объект из формы 
      m_pPerformance.Title = labTitle.Text;
      m_pPerformance.Duration = Convert.ToInt32(nudDuration.Value);

      //decimal pV = nudDuration.Value;
      //// 1.
      //m_pPerformance.Duration = (int)pV;
      //// 2.
      //m_pPerformance.Duration = Convert.ToInt32(pV);
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      h_FillFromForm();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      h_FillToForm();
    }
  }
}
