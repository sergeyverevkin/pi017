using sokoban_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sokoban_wf
{
  public partial class Form1 : Form
  {
    public CGame m_pGame;

    public Form1()
    {
      InitializeComponent();
      m_pGame = new CGame();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      m_pGame.LoadTest();
      h_Refresh();
    }

    private void h_Refresh()
    {
      StringBuilder sbList = new StringBuilder();

      for (int iY = 0; iY < m_pGame.Height; iY++)
      {
        string sLine = "";
        for (int iX = 0; iX < m_pGame.Width; iX++) {
          List<CCell> ar = m_pGame.FindCell(iX, iY);
          // h_Paint(iX, iY, ar);
          string sSym = " ";
          if (ar.Any(p => p is CWorkerCell)) {
            sSym = "+";
          }
          if (ar.Any(p => p is CWallCell)) {
            sSym = "-";
          }
          if (ar.Any(p => p is CBoxCell)) {
            sSym = "*";
          }
          if (ar.Any(p => p is CExitCell)) {
            sSym = ".";
          }

          sLine += sSym;
        }
        sbList.AppendLine(sLine);
      }

      richTextBox1.Text = sbList.ToString();
    }

  }
}
