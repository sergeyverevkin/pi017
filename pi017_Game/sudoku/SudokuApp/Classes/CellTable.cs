using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApp.Classes
{
  public class CCellTable
  {
    private Random m_pRandom = new Random();
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
