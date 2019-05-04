using System;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Windows.Forms;
using Quiz.Classes.Model;
using Quiz.Classes.Service;

namespace QuizAdmin
{
  public partial class MainForm : Form
  {
    private DbQuiz m_pQuiz;
    private ServiceHost m_pHost;

    public MainForm()
    {
      InitializeComponent();
      m_pQuiz = new DbQuiz();
      m_pQuiz.TestFill();

      h_InitService();
      h_RefreshServiceState(false);
    }

    private void h_RefreshServiceState(
      bool bStarted
      )
    {
      стартToolStripMenuItem.Enabled = !bStarted;
      стопToolStripMenuItem.Enabled = bStarted;
    }

    private void h_InitService()
    {
      string sUrlService = 
        "http://0.0.0.0:8000/Service";
      string sUrlServiceMeta =
        "http://0.0.0.0:8000/Service/Meta";

      BasicHttpBinding pBinding = new
        BasicHttpBinding();
      pBinding.Security.Transport.ClientCredentialType 
        = HttpClientCredentialType.None;
      pBinding.Security.Mode = 
        BasicHttpSecurityMode.None;

      ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
      smb.HttpGetEnabled = true;
      smb.HttpGetUrl = new Uri(sUrlServiceMeta);
      smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;

      m_pHost = 
        new ServiceHost(typeof(CGameServer));
      m_pHost.Description.Behaviors.Add(smb);
      m_pHost.AddServiceEndpoint(
        typeof(IGame),
        pBinding,
        sUrlService
      );
      m_pHost.AddServiceEndpoint(
        typeof(IMetadataExchange),
        MetadataExchangeBindings.CreateMexHttpBinding(),
        sUrlServiceMeta
      );

    }


    private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_pQuiz.Load("");
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_pQuiz.Save("");
    }

    private void стартToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_pHost.Open();
      h_RefreshServiceState(true);
    }

    private void стопToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_pHost.Close();
      h_RefreshServiceState(false);
    }
  }
}
