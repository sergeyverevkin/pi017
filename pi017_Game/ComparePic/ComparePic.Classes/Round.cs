using System.Collections.Generic;

namespace ComparePic.Classes
{
  /*
   * - ПараИзображений;
     - выбранные параОбластей[].
    */
  public class CRound
  {
    public CRound(
      CPicturePair picturePair)
    {
      PicturePair = picturePair;
      AreaList = new List<CArea>();
    }

    public CPicturePair PicturePair { get; set; }
    public List<CArea> AreaList { get; set; }
  }
}