using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sokoban_classes
{
  /*
   * Игровое поле
   *  - стена
   *  - пустое поле
   *  - ящик
   *  - грузчик
   *  - точки выхода
   *  
   */



  /// <summary>
  /// Координата
  /// </summary>
  public class CCoord
  {
    public int X;
    public int Y;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{X};{Y}";
    }

  }

  #region CCell classes


  /// <summary>
  /// Базовый класс для всех ячеек на поле (квадратных)
  /// </summary>
  public class CCell
  {
    /// <summary>
    /// Позиция ячейка
    /// </summary>
    public CCoord Position;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    public CCell(int iX, int iY)
    {
      Position = new CCoord()
      {
        X = iX,
        Y = iY
      };
    }

    public override string ToString()
    {
      return $"{this.GetType().Name} / {Position.ToString()}";
    }
  }

  /// <summary>
  /// Ячейка-стена
  /// </summary>
  public class CWallCell : CCell
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    public CWallCell(int iX, int iY) : base(iX, iY)
    {
    }
  }

  /// <summary>
  /// Пустая ячейка
  /// </summary>
  public class CWayCell : CCell
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    public CWayCell(int iX, int iY) : base(iX, iY)
    {
    }
  }
  /// <summary>
  /// Ячейка выхода
  /// </summary>
  public class CExitCell : CCell
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    public CExitCell(int iX, int iY) : base(iX, iY)
    {
    }
  }
  /// <summary>
  /// Ячейка ящика
  /// </summary>
  public class CBoxCell : CCell
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    public CBoxCell(int iX, int iY) :
      base(iX, iY)
    {
    }
  }

  /// <summary>
  /// Ячейка грузчика
  /// </summary>
  public class CWorkerCell : CCell
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    public CWorkerCell(int iX, int iY) : base(iX, iY)
    {
    }
  }

  #endregion

  /// <summary>
  /// Игровое поле
  /// </summary>
  public class CGame
  {
    /// <summary>
    /// Ширина
    /// </summary>
    public int Width;
    /// <summary>
    /// Высота
    /// </summary>
    public int Height;
    /// <summary>
    /// Ячейки поля
    /// </summary>
    public List<CCell> Cells { get; private set; }


    /// <summary>
    /// Конструктор
    /// </summary>
    public CGame()
    {
      //создаем список при начале игры
      Cells = new List<CCell>();
    }
    /// <summary>
    /// Загрузка игрового поля
    /// </summary>
    public void Load()
    {
      Cells.Clear();
      string sFilename = @"$data\sokoban.csv";
      // загрузка из файла
      string sText = File.ReadAllText(sFilename);
      string[] arLines = sText.Split(new[] { '\r' });

      Height = arLines.Length;
      for (int iY = 0; iY < arLines.Length; iY++) {
        string sLine = arLines[iY].Trim();
        if (String.IsNullOrEmpty(sLine)) continue;
        string[] arCols = sLine.Split(';');
        Width = arCols.Length;
        for (int iX = 0; iX < Width; iX++) {
          string sS = arCols[iX];
          CCell pC;
          switch (sS) {
            case "x":
              pC = new CWorkerCell(iX, iY);
              break;
            case "#":
              pC = new CWallCell(iX, iY);
              break;
            case "+":
              pC = new CExitCell(iX, iY);
              break;
            case "@":
              pC = new CBoxCell(iX, iY);
              break;
            default:
              pC = new CCell(iX, iY);
              break;

          }
          // добавляем в массив ячеек созданную ячейку со стеной
          Cells.Add(pC);
        }
      }
    }
    /// <summary>
    /// Загрузка игрового поля (тестовое)
    /// </summary>
    public void LoadTest()
    {
      Width = 4;
      Height = 4;

      int iY = 0;
      int iX = 0;

      for (int iiX = 0; iiX < Width; iiX++) {
        CWallCell pC = new CWallCell(iiX, iY);
        // добавляем в массив ячеек созданную ячейку со стеной
        Cells.Add(pC);
      }

      iY = Height - 1;
      for (int iiX = 0; iiX < Width; iiX++) {
        CWallCell pC = new CWallCell(iiX, iY);
        // добавляем в массив ячеек созданную ячейку со стеной
        Cells.Add(pC);
      }

      iX = 0;
      for (int iiY = 0; iiY < Height; iiY++) {
        CWallCell pC = new CWallCell(iX, iiY);
        // добавляем в массив ячеек созданную ячейку со стеной
        Cells.Add(pC);
      }

      iX = Width - 1;
      for (int iiY = 0; iiY < Height; iiY++) {
        CWallCell pC = new CWallCell(iX, iiY);
        // добавляем в массив ячеек созданную ячейку со стеной
        Cells.Add(pC);
      }

      CWorkerCell pW = new CWorkerCell(Width / 2, Height / 2);
      Cells.Add(pW);

      CBoxCell pB = new CBoxCell(Width / 2 + 1, Height / 2);
      Cells.Add(pB);
    }

    /// <summary>
    /// Поиск ячеек в заданной позиции
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    /// <returns></returns>
    public List<CCell> FindCell(int iX, int iY)
    {
      List<CCell> arCell = new List<CCell>();
      for (int ii = 0; ii < Cells.Count; ii++) {
        if (iX == Cells[ii].Position.X) {
          if (iY == Cells[ii].Position.Y) {
            arCell.Add(Cells[ii]);
          }
        }
      }

      return arCell;
    }



    public void PressUp()
    {
      CWorkerCell[] arCells = Cells
          .Where(p => p is CWorkerCell)
        .Cast<CWorkerCell>()
        .ToArray();
      foreach (CWorkerCell pCell in arCells) {
        if (h_WorkerCanGoUp(pCell)) {
          pCell.Position.Y = pCell.Position.Y - 1;
        }
      }
    }

    public void PressDown()
    {
      CWorkerCell[] arCells = Cells
        .Where(p => p is CWorkerCell)
        .Cast<CWorkerCell>()
        .ToArray();
      foreach (CWorkerCell pCell in arCells) {
        // pCell.Position.X; pCell.Position.Y
        // pCell.Position.X; pCell.Position.Y + 1
        if (h_WorkerCanGoDown(pCell)) {
          pCell.Position.Y = pCell.Position.Y + 1;
        }
      }
    }

    private bool h_WorkerCanGoDown(CWorkerCell pCell)
    {
      List<CCell> arCells =
        FindCell(
          pCell.Position.X,
          pCell.Position.Y + 1);
      if (arCells.Any(p => p is CWallCell)) {
        return false;
      }
      if (arCells.Any(p => p is CBoxCell)) {
        List<CCell> arCellsAfter =
          FindCell(
            pCell.Position.X,
            pCell.Position.Y + 2);
        if (arCellsAfter.Any(p => p is CWallCell)) {
          return false;
        }
        if (arCellsAfter.Any(p => p is CBoxCell)) {
          return false;
        }

        CCell pBox = arCells.FirstOrDefault(p => p is CBoxCell);
        if (pBox != null)
        {
          pBox.Position.Y = pBox.Position.Y + 1;
        }
        return true;
      }


      return true;
    }

    private bool h_WorkerCanGoUp(
      CWorkerCell pCell
      )
    {
      List<CCell> arCells =
        FindCell(
          pCell.Position.X,
          pCell.Position.Y - 1);
      if (arCells.Any(p => p is CWallCell)) {
        return false;
      }
      if (arCells.Any(p => p is CBoxCell)) {
        List<CCell> arCellsAfter =
          FindCell(
            pCell.Position.X,
            pCell.Position.Y - 2);
        if (arCellsAfter.Any(p => p is CWallCell)) {
          return false;
        }
        if (arCellsAfter.Any(p => p is CBoxCell)) {
          return false;
        }
        CCell pBox = arCells.FirstOrDefault(p => p is CBoxCell);
        if (pBox != null) {
          pBox.Position.Y = pBox.Position.Y - 1;
        }
        return true;
      }


      return true;
    }
  }

}
