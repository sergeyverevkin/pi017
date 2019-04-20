using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost4.Classes
{
  public class CPicture
  {
    public CPicture(string filename)
    {
      CategoryList = new List<CCategory>();
      Filename = filename;
    }

    public int Id { get; set; }
    public string Filename { get; set; }
    public List<CCategory> CategoryList { get; private set; } 
  }
}
