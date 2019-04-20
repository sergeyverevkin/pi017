using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TooHotApp.Classes;

namespace TooHotApp
{
  public partial class Form1 : Form
  {
    private CGame m_pGame;

    public Form1()
    {
      InitializeComponent();
      m_pGame = new CGame();
      m_pGame.New(2);
      h_Refresh();
    }

    private void h_Refresh()
    {
      foreach (CDigit p in m_pGame.Digits)
      {
        /// -----------------
        Button btn = btn1;
        Panel pan = panel1;
        /// -----------------

        if (!p.UserValue.HasValue)
        {
          btn.BackColor = Color.BlanchedAlmond;
          btn.Text = "-";
        }
        else
        {
          btn.BackColor = Color.White;
          btn.Text = p.UserValue.Value.ToString();
        }

        EAccuracy en = p.GetAccuracy();
        switch (en)
        {
          case EAccuracy.Unknown:
            break;
          case EAccuracy.Cold:
            pan.BackColor = Color.Blue;
            break;
          case EAccuracy.Hot:
            pan.BackColor = Color.Yellow;
            break;
          case EAccuracy.Hotter:
            pan.BackColor = Color.Red;
            break;
          case EAccuracy.Correct:
            pan.BackColor = Color.White;
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
      }
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {

    }

    private void toolStripMenuItem3_Click(
      object sender, EventArgs e)
    {
      ToolStripItem p = (sender as ToolStripItem);
      int i = Int32.Parse(p.Text);
      m_pGame.Digits[1].UserValue = i;
      h_Refresh();
    }
  }
}
