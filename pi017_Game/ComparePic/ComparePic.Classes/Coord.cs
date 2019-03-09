using System;

namespace ComparePic.Classes
{
  /// <summary>
  /// Coord
  /// </summary>
  public class CCoord
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public CCoord(int x, int y)
    {
      X = x;
      Y = y;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public CCoord(string x, string y)
    {
      X = Int32.Parse(x);
      Y = Int32.Parse(y);
    }
    /// <summary>
    /// X
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Y
    /// </summary>
    public int Y { get; set; }

  }
}