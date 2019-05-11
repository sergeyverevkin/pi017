using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;
using CQuestion = WindowsFormsApp1.GameServiceReference.CQuestion;
using GameClient = WindowsFormsApp1.GameServiceReference.GameClient;

namespace WindowsFormsApp1
{

  public partial class MainForm : Form
  {
    private GameClient m_pClient;
    private PictureServerClient m_pPictureClient;
    public MainForm()
    {
      InitializeComponent();

      string sAddress = 
        "http://127.0.0.1:8000/Service";
      BasicHttpBinding pBinding = new BasicHttpBinding();

      const int iMaxBytes = 2048000;
      pBinding.ReaderQuotas.MaxArrayLength = iMaxBytes;
      pBinding.ReaderQuotas.MaxStringContentLength = iMaxBytes;
      pBinding.MaxReceivedMessageSize = iMaxBytes;

      m_pClient = new GameClient(
        pBinding,
        new EndpointAddress(sAddress));
      m_pPictureClient = new PictureServerClient(
        pBinding,
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

    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
    {
      //if (e.Action == TabControlAction.Deselecting)
      //{
      //  e.Cancel = true;
      //}
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int iIndex = 1;
      // 
      iIndex = tabControl1.SelectedIndex + 1;
      if (iIndex >= tabControl1.TabCount)
      {
        iIndex = 0;

      }
      tabControl1.SelectedIndex = iIndex;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      try
      {
        h_BtnClick();
      }
      catch (Exception pE)
      {
        MessageBox.Show($"Ошибка соединения с сервером: {pE.Message}");
      }
    }

    private void h_BtnClick()
    {
      CPicture pPicture =
        m_pPictureClient.GetMetaPicture();
      using (MemoryStream pStream =
        new MemoryStream(pPicture.Content)
      )
      {
        pictureBox1.Image = Image.FromStream(pStream);
        button1.Text = pPicture.FileName;
      }


      CPictureSet pPictureSet =
        m_pPictureClient.GetPictureSet();
      Text = pPictureSet.Title;
    }
  }
}
