using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Quiz.Classes.Model
{
  [DataContract]
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

    [DataMember]
    [XmlAttribute("id")]
    public int Id { get; set; }
    [DataMember]
    [XmlElement("txt")]
    public string Text { get; set; }

    private Color m_backColor;
    [XmlIgnore]
    public Color BackColor
    {
      get { return m_backColor; }
      set
      {
        if (value == Color.Red) throw new KeyNotFoundException("");
        m_backColor = value;
      }
    }
  }

  [DataContract]
  public class CCategoryList : List<CCategory>
  {
    //public new CCategory Items
    //{
    //  get { return Items; }
    //}

  }
}