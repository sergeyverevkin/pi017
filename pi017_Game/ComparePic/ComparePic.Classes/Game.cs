namespace ComparePic.Classes
{
  /*
   Найди отличия

    БД изображений:
      - ПараИзображений[]

    - ПараИзображений
      - адрес картинки (./images/001/);
      - наименование (текст задания);
      - областьОтличий[];
      - координаты картинки №1;
      - координаты картинки №2.

    - область отличий
      - x1,y1,x2,y2 (координаты прямоугольника;




    - Игра
      - Игрок;
      - Текущее задание
    - Игрок
      - наименование;
      - очки;
    - Текущее задание:
      - ПараИзображений;
      - выбранные параОбластей[].
    
    
     */

  public class CGame
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="player"></param>
    /// <param name="round"></param>
    public CGame(CPlayer player, CRound round)
    {
      Player = player;
      Round = round;
    }

    public CPlayer Player { get; set; }
    public CRound Round { get; set; }
  }
}
