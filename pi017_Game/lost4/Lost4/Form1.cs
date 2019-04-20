using Lost4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lost4
{
  public partial class Form1 : Form
  {
    private CGame m_pGame;

    public Form1()
    {
      InitializeComponent();
      m_pGame = new CGame();
    }
  }
}
