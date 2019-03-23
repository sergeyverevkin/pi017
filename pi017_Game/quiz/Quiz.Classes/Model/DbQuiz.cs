using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Quiz.Classes.Model
{
/*
  База вопросов:
    - Вопрос[]
    - Категория[]
    */
  public class DbQuiz
  {
    public DbQuiz()
    {
      QuestionList = new CQuestionList();
      CategoryList = new CCategoryList();
    }

    /// <summary>
    /// Сохранение в файл
    /// </summary>
    /// <param name="sFolder"></param>
    public void Save(string sFolder)
    {
      h_SaveQuestions();
      h_SaveCategories();
    }

    private void h_SaveCategories()
    {
      using (XmlWriter pX = XmlWriter.Create(
        "$data/categories.xml",
        new XmlWriterSettings()
        {
          Indent = true,
          Encoding = Encoding.GetEncoding(1251)
        })) {
        XmlSerializer pSerializer =
          new XmlSerializer(typeof(CCategoryList));
        pSerializer.Serialize(pX, CategoryList);
      }
    }

    private void h_SaveQuestions()
    {
      using (XmlWriter pX = XmlWriter.Create(
        "$data/questions.xml",
        new XmlWriterSettings()
        {
          Indent = true,
          Encoding = Encoding.GetEncoding(1251)
        })) {
        XmlSerializer pSerializer =
          new XmlSerializer(typeof(CQuestionList));
        pSerializer.Serialize(pX, QuestionList);
      }

    }


    /// <summary>
    /// Загрузка из файла
    /// </summary>
    /// <param name="sFolder"></param>
    public void Load(string sFolder)
    {
      // 1. Считываем все возможные категории
      // 2. Создаем массив объектов категорий
      h_LoadCategories();
      // 3. Считываем вопросы
      // 4. Создаем массив объектов вопросов
      h_LoadQuestions();
    }

 
    public CQuestionList QuestionList { get; set; }
    public CCategoryList CategoryList { get; set; }




    private void h_LoadCategories()
    {
      // CategoryList.Clear();
      using (XmlReader pX = XmlReader.Create(
        "$data/categories.xml")) {
        XmlSerializer pSerializer =
          new XmlSerializer(typeof(CCategoryList));
        CategoryList = (CCategoryList)
          pSerializer.Deserialize(pX);
      }
    }

    private void h_LoadQuestions()
    {
      // TODO, 16.03.2019 - восстановление и сохранение вопросов

    }

    public void TestFill()
    {
      CCategory pCat1 = new CCategory(1, "Категория 1");
      CCategory pCat2 = new CCategory(2, "Категория 2");
      CategoryList.Add(pCat1);
      CategoryList.Add(pCat2);
      CategoryList.Add(new CCategory(3, "Категория 3"));
      CategoryList.Add(new CCategory(4, "Категория 4"));


      CQuestion pQ1 = new CQuestion(1, "questionText1", 1);
      pQ1.CategoryList.Add(pCat1);
      QuestionList.Add(pQ1);

      CQuestion pQ2 = new CQuestion(2, "questionText2", 1);
      pQ2.CategoryList.Add(pCat1);
      QuestionList.Add(pQ2);

      CQuestion pQ3 = new CQuestion(3, "questionText3", 1);
      pQ3.CategoryList.Add(pCat2);
      QuestionList.Add(pQ3);


    }
  }
}
