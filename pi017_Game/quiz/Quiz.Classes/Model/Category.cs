using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;

namespace Quiz.Classes.Model
{
  public class CCategory
  {
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="id"></param>
    /// <param name="text"></param>
    public CCategory(int id, string text)
    {
      Id = id;
      Text = text;
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    private CCategory()
    {
    }



    /*
     - название
     - идентификатор
    */

    [XmlAttribute("id")]
    public int Id { get; set; }
    [XmlElement("txt")]
    public string Text { get; set; }
    [XmlIgnore]
    public Color BackColor { get; set; }
  }

  public class CCategoryList : List<CCategory>
  {
    //public new CCategory Items
    //{
    //  get { return Items; }
    //}

  }
}