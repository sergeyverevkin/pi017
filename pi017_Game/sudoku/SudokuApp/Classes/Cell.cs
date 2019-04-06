using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApp.Classes
{

  /// <summary>
  /// Клетка поля
  /// </summary>
  public class CCell
  {
    /// <summary>
    /// Корректное значение
    /// </summary>
    public string Value
    {
      get; set;
    }
  }

  /// <summary>
  /// Заранее установленная клетка
  /// </summary>
  public class CPredefinedCell : CCell
  {

  }

  public class CUserCell: CCell
  {
    public string UserValue { get; set; }
  }
}
