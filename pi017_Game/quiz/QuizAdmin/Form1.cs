using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Classes.Model;

namespace QuizAdmin
{
  public partial class Form1 : Form
  {
    private DbQuiz m_pQuiz;

    public Form1()
    {
      InitializeComponent();
      m_pQuiz = new DbQuiz();
      m_pQuiz.TestFill();
    }

    private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_pQuiz.Load("");
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_pQuiz.Save("");
    }
  }
}
