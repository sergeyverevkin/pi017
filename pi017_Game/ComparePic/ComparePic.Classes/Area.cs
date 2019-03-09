using System;

namespace ComparePic.Classes
{
  public class CArea
  {
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="X1"></param>
    /// <param name="Y1"></param>
    /// <param name="X2"></param>
    /// <param name="Y2"></param>
    public CArea(int X1, int Y1, int X2, int Y2)
    {
      LeftTop = new CCoord (X1, Y1);
      RightBottom = new CCoord(X2, Y2);
    }

    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="sArea"></param>
    public CArea(string sArea)
    {
      string[] ar = sArea.Split(';');
      if (ar.Length != 4) return;
      int X1 = Int32.Parse(ar[0]);
      int Y1 = Int32.Parse(ar[1]);
      int X2 = Int32.Parse(ar[2]);
      int Y2 = Int32.Parse(ar[3]);
      LeftTop = new CCoord(X1, Y1);
      RightBottom = new CCoord(X2, Y2);
    }
    /// <summary>
    /// X1, Y1
    /// </summary>
    public CCoord LeftTop { get; set; }
    /// <summary>
    /// X2, Y2
    /// </summary>
    public CCoord RightBottom { get; set; }

  }
}