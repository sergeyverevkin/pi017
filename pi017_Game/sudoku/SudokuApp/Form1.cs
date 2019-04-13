using SudokuApp.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using SystemTimer = System.Timers.Timer;
using FormsTimer = System.Windows.Forms.Timer;

namespace SudokuApp
{
  public partial class Form1 : Form
  {
    private CCellTable m_pTable;
    private SystemTimer m_pTimer;
    private DateTime m_dtTimer;
    private Bee m_pBee;

    public Form1()
    {
      InitializeComponent();
      m_pBee = new Bee(pictureBox1.Width, pictureBox1.Height);
      m_pTimer = new SystemTimer();
      m_pTimer.SynchronizingObject = this;
      m_pTimer.Interval = 100;
      m_pTimer.Enabled = true;
      // m_pTimer.AutoReset = true;
      m_pTimer.Start();
      m_pTimer.Elapsed += PTimerOnElapsed;
      m_pTable = new CCellTable("$data/sudoku.csv", 40);

      h_DrawCellTable();
    }

    private void PTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
    {
      h_DrawCellTable();
      m_pBee.Timer();
      pictureBox1.Invalidate();
      return;

      if (this.InvokeRequired)
      {
        //this.Invoke(new Action() =>
        //{
        //  return this.Text = elapsedEventArgs.SignalTime.ToString("s");
        //});
        this.Text = elapsedEventArgs.SignalTime.ToString("s");
      }
      else
      {
        this.Text = elapsedEventArgs.SignalTime.ToString("s");
      }
      //Thread.Sleep(300);
      //if (elapsedEventArgs.SignalTime < m_dtTimer)
      //{
      //  return;
      //}
      //// ....
      //m_dtTimer = elapsedEventArgs.SignalTime;
    }

    private void h_DrawCellTable()
    {
      const int FieldSize = 9;

      this.panButtons.SuspendLayout();
      // рисуем каждую клетку
      for (int iX = 0; iX < FieldSize; iX++) {
        for (int iY = 0; iY < FieldSize; iY++) {
          CCell pCell = m_pTable.Get(iX, iY);
          string sBtnName = $"btn{iX}{iY}";
          Button pButton = h_FindButton(sBtnName);
          // создали, если не нашли
          if (pButton == null) {
            pButton = h_CreateButton(
              iX, iY, pCell, sBtnName);
          }

          // обновили состояние
          h_RefreshButton(pCell, pButton);
        }
      }
      this.panButtons.ResumeLayout();
    }

    private static void h_RefreshButton(CCell pCell, Button pButton)
    {
      if (pCell is CPredefinedCell) {
        pButton.Text = pCell.Value;
      }
      else
      if (pCell is CUserCell) {
        if (pCell.Value != (pCell as CUserCell).UserValue) {
          pButton.BackColor = Color.PaleVioletRed;
        }
        else {
          pButton.BackColor = SystemColors.ActiveCaptionText;
        }

        pButton.ForeColor = Color.Blue;
        pButton.Text = (pCell as CUserCell).UserValue;
      }
    }

    private Button h_FindButton(string sBtnName)
    {
      Button pButton = null;
      foreach (Control pControl in
        this.panButtons.Controls) {
        if (!(pControl is Button)) continue;
        if (pControl.Name.Equals(sBtnName)) {
          return pControl as Button;
        }
      }
      return null;
    }

    private Button h_CreateButton(int iX, int iY, CCell pCell, string sBtnName)
    {
      Button pButton;
      const int CellWidth = 24;
      const int CellHeight = 24;
      const int CellMargin = 10;
      const int FieldDeltaX = 10;
      const int FieldDeltaY = 10;
      int iCellX = FieldDeltaX + iX * (CellWidth + CellMargin);
      int iCellY = FieldDeltaY + iY * (CellHeight + CellMargin);

      pButton = new Button();
      this.panButtons.Controls.Add(pButton);
      pButton.BackColor = SystemColors.ActiveCaptionText;
      pButton.Location = new Point(iCellX, iCellY);
      pButton.Name = sBtnName;
      pButton.Tag = pCell; 
      pButton.Size = new Size(CellWidth, CellHeight);
      pButton.UseVisualStyleBackColor = false;

      if (pCell is CUserCell) {
        pButton.Click += btnClick;
      }

      return pButton;
    }

    private void btnClick(object sender, EventArgs e)
    {
      CUserCell pCell = (sender as Button).Tag as CUserCell;
      pCell.UserValue = "5";
      h_DrawCellTable();
    }

    private void pictureBox1_Paint(
        object sender,
        PaintEventArgs e)
    {
      const int FieldSize = 9;
      const int CellWidth = 48;
      const int CellHeight = 48;
      const int FieldDeltaX = 0;
      const int FieldDeltaY = 0;

      const string ImageDir = "$data/images";

      // рисуем подложку
      Image pImage = new Bitmap($"{ImageDir}/bg.png");
      e.Graphics.DrawImage(pImage, new Point(0, 0));
      e.Graphics.DrawEllipse(Pens.Blue, (float)m_pBee.X, (float)m_pBee.Y, (float)10, (float)10);

      /*
      // рисуем каждую клетку
      for (int iX = 0; iX < FieldSize; iX++) {
        for (int iY = 0; iY < FieldSize; iY++) {
          int iCellX = FieldDeltaX + iX * CellWidth;
          int iCellY = FieldDeltaY + iY * CellHeight;
          CCell pCell = m_pTable.Get(iX, iY);
          string sFn = $"{ImageDir}/{pCell.Value}.png";
          if (!File.Exists(sFn)) {
            sFn = $"{ImageDir}/1.png";
          }
          Bitmap pCellImage = new Bitmap(sFn);
          // pCellImage.
          e.Graphics.DrawImage(pCellImage,
            new Point(iCellX, iCellY));
        }
        pictureBox1.Invalidate();
      }
      */
    }

    private void timerWindowsForms_Tick(object sender, EventArgs e)
    {
      h_DrawCellTable();
      // Thread.Sleep(10);
      // MessageBox.Show(DateTime.Now.ToString("s"));
      // MessageBox.Show("ok");
      // this.Text = DateTime.Now.ToString("s");
      // Refresh();
    }

    private void panButtons_DoubleClick(object sender, EventArgs e)
    {
      h_DrawCellTable();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      m_pBee.MoveDown();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      m_pBee.MoveUp();
    }
  }
}
