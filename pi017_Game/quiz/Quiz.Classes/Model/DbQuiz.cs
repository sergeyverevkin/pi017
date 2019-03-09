using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Classes.Model
{
/*
  База вопросов:
    - Вопрос[]
    - Категория[]
    */
  class DbQuiz
  {
    public DbQuiz()
    {
      QuestionList = new List<CQuestion>();
      CategoryList = new List<CCategory>();
    }

    /// <summary>
    /// Сохранение в файл
    /// </summary>
    /// <param name="sFolder"></param>
    public void Save(string sFolder)
    {
      // TODO
    }


    /// <summary>
    /// Загрузка из файла
    /// </summary>
    /// <param name="sFolder"></param>
    public void Load(string sFolder)
    {
      // TODO
    }

    public List<CQuestion> QuestionList { get; set; }
    public List<CCategory> CategoryList { get; set; }

  }
}
