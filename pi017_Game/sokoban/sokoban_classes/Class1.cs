using System.Collections.Generic;

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

    public CCell(int iX, int iY)
    {
      Position = new CCoord()
      {
        X = iX,
        Y = iY
      };
    }
  }

  /// <summary>
  /// Ячейка-стена
  /// </summary>
  public class CWallCell : CCell
  {
    public CWallCell(int iX, int iY) : base(iX, iY)
    {
    }
  }
  /// <summary>
  /// Пустая ячейка
  /// </summary>
  public class CWayCell : CCell
  {
    public CWayCell(int iX, int iY) : base(iX, iY)
    {
    }
  }
  /// <summary>
  /// Ячейка выхода
  /// </summary>
  public class CExitCell : CCell
  {
    public CExitCell(int iX, int iY) : base(iX, iY)
    {
    }
  }
  /// <summary>
  /// Ячейка ящика
  /// </summary>
  public class CBoxCell : CCell
  {
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
      // загрузка из файла

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



  }

}
