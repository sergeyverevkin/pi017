using ComparePic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparePicGame
{
  public partial class Form1 : Form
  {
    private CDbGame m_pDbGame;

    public Form1()
    {
      InitializeComponent();
      m_pDbGame = new CDbGame();
      m_pDbGame.Load("../ComparePic/$data/images/");
      // CPicturePair pP = m_pDbGame.PictureList[0];
    }
  }
}
