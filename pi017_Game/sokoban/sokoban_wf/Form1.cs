using sokoban_classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sokoban_wf
{
  public partial class Form1 : Form
  {
    public CGame m_pGame;
    Random m_pRand = new Random();

    public Form1()
    {
      InitializeComponent();
      m_pGame = new CGame();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      m_pGame.Load();
      h_Refresh();
      //MessageBox.Show( h_GetRandom(
      //  new[] { 1, 2 },
      //  new[] { 90, 10 }
      //  ).ToString());
    }

    /// <summary>
    /// Демонстрации генерации случайного выбора 
    /// из заданных вариантов
    /// </summary>
    /// <param name="arVariant">Список возможных вариантов</param>
    /// <param name="arPercent">Вероятность их возникновения</param>
    /// <returns></returns>
    private int h_GetRandom(
      int[] arVariant,
      int[] arPercent)
    {
      int iSum = 0;
      // 1    2    3
      // 70%, 20%, 10% 
      // iRnd = 20 -> 1
      // iRnd = 69 -> 1
      // iRnd = 72 -> 2
      // iRnd = 96 -> 3
      // 0-69 -> 1, 70-89 -> 2, 90-99 -> 3 

      // iRnd = [0 ; 99]
      // 100 -> arPercent.Sum(p=>p);
      int iRnd = m_pRand.Next(0, 100);
      for (int ii = 0; ii < arPercent.Length; ii++) {
        iSum += (int)arPercent[ii];
        if (iRnd < iSum) return arVariant[ii];
      }
      return arVariant[0];
    }

    private void h_Refresh()
    {
      h_RefreshText();
      h_RefreshPicture();
    }

    private void h_RefreshPicture()
    {
      Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
      using (Graphics g = Graphics.FromImage(bmp)) {
        g.Clear(Color.White);
        for (int iY = 0; iY < m_pGame.Height; iY++) {
          for (int iX = 0; iX < m_pGame.Width; iX++) {
            List<CCell> ar = m_pGame.FindCell(iX, iY);
            h_RefreshPicturePaint(g, iX, iY, ar);
          }
        }
      }
      pictureBox1.Image = bmp;
      pictureBox1.Invalidate();
    }

    private void h_RefreshPicturePaint(
      Graphics graphics, 
      int iX, 
      int iY, 
      List<CCell> ar)
    {
      int iW = 25;
      int iH = 25;
      Pen pPen = null;
      if (ar.Any(p => p is CWorkerCell))
      {
        pPen = Pens.Red;
      }
      else
      if (ar.Any(p => p is CWallCell)) {
        pPen = Pens.Black;
      }
      else
      if (ar.Any(p => p is CBoxCell))
      {
        pPen = Pens.Blue;
      }

      if (pPen != null)
      {
        // graphics.DrawImage(Image.FromFile(), iX * iW, iY * iH);
        graphics.DrawEllipse(pPen, 
          iX * (iW / 1), 
          iY * (iH / 1), 
          iW, iH);
      }
    }

    private void h_RefreshText()
    {
      StringBuilder sbList = new StringBuilder();

      for (int iY = 0; iY < m_pGame.Height; iY++) {
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

    private void btnUp_Click(object sender, EventArgs e)
    {
      m_pGame.PressUp();
      h_Refresh();
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      m_pGame.PressDown();
      h_Refresh();
    }
  }
}
