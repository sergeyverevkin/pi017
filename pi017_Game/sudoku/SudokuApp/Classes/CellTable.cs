using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadTimer = System.Threading.Timer;

namespace SudokuApp.Classes
{
  public class CCellTable
  {
    private Random m_pRandom = new Random();
    private ThreadTimer m_pTimer;
    private List<List<CCell>> _cells = new List<List<CCell>>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    /// <returns></returns>
    public CCell Get(int X, int Y)
    {
      return _cells[X][Y];
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public CCellTable(int iPercent)
    {
      const int Size = 9;

      m_pTimer = new ThreadTimer(h_OnTimer);
      TimeSpan tsStart = new TimeSpan(0,0,3);
      m_pTimer.Change(tsStart, tsStart);

      for (int ii = 0; ii < Size; ii++) {
        List<CCell> pRow = new List<CCell>();
        _cells.Add(pRow);
        for (int jj = 0; jj < Size; jj++)
        {
          bool bIsIn = (m_pRandom.Next(0, 100) < iPercent);
          CCell pCell = bIsIn
            ? (CCell)new CPredefinedCell()
            : (CCell)new CUserCell();
          pRow.Add(pCell);
        }
      }
    }

    private void h_OnTimer(object state)
    {
      if (m_pRandom.Next(0, 100) < 50)
      {
        int iCol = m_pRandom.Next(0, 9);
        var pCell = Get(iCol, 0);
        pCell.Value = "0";
      }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public CCellTable(string sFileName, int iPercent) : 
      this(iPercent)
    {
      string[] arLines = File.ReadAllLines(sFileName);
      for (int ii = 0; ii < arLines.Length; ii++)
      {
        string[] arCols = arLines[ii].Split(new[] {';'});
        for (int jj = 0; jj < arCols.Length; jj++)
        {
          CCell pCell = _cells[ii][jj];
          pCell.Value = arCols[jj];
        }
      }
    }

  }
}
