using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GameServiceReference;

namespace WindowsFormsApp1
{

  public partial class Form1 : Form
  {
    private GameClient m_pClient;
    public Form1()
    {
      InitializeComponent();

      string sAddress = "http://127.0.0.1:8000/Service";
      m_pClient = new GameClient(
        new BasicHttpBinding(),
        new EndpointAddress(sAddress));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        CQuestion pQ = m_pClient.GetQuestion();
        textBox1.Text = pQ.Text;
      }
      catch (Exception pE)
      {
        textBox1.Text = pE.Message;
      }
    }
  }
}
