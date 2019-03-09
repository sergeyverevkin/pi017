using System.Collections.Generic;

namespace ComparePic.Classes
{
  /*      
        - адрес картинки (./images/001/);
        - наименование (текст задания);
        - параОбластей[].
  */
  public class CPicturePair
  {
    /// <summary>
    /// .ctor
    /// </summary>
    public CPicturePair()
    {
      AreaList = new List<CArea>();
    }

    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Адрес хранения изображения
    /// </summary>
    public string Uri { get; set; }
    /// <summary>
    /// Текст задания
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// области отличий
    /// </summary>
    public List<CArea> AreaList { get; set; }

    /// <summary>
    /// Координата начала первого изображения
    /// </summary>
    public CCoord Picture1 { get; set; }
    /// <summary>
    /// Координата начала второго изображения
    /// </summary>
    public CCoord Picture2 { get; set; }
  }

}