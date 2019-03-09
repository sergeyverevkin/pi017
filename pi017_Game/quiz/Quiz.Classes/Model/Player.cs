using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Classes.Model
{
  /// <summary>
  ///   Игрок:
  ///     - имя
  ///     - балл
  ///     - в игре
  /// </summary>
  public class CPlayer
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="name"></param>
    public CPlayer(string name)
    {
      Name = name;
    }

    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// баллы
    /// </summary>
    public int Score { get; set;}

    /// <summary>
    /// Активный ли игрок
    /// </summary>
    public bool IsActive { get; set; }
  }
}
