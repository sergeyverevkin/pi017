using Quiz.Classes.Model;
using System;
using System.IO;

namespace Quiz.Classes.Service
{
  /// <summary>
  /// "Универсальный" класс
  /// </summary>
  public class CGameServer : 
    IGame, 
    IPictureServer
  {
    private DbQuiz m_pQuiz;
    private Random m_pRandom;
    /// <summary>
    /// .ctor
    /// </summary>
    public CGameServer()
    {
      m_pRandom = new Random();
      m_pQuiz = new DbQuiz();
      m_pQuiz.TestFill();
    }

    #region interface implementation

    /// <summary>
    /// Получить произвольный вопрос
    /// </summary>
    /// <returns></returns>
    public CQuestion GetQuestion()
    {
      int iCount = m_pQuiz.QuestionList.Count;
      int iQNum = m_pRandom.Next(0, iCount);
      return m_pQuiz.QuestionList[iQNum];
    }

    /// <summary>
    /// Получить список категорий
    /// </summary>
    /// <returns></returns>
    public CCategoryList GetCategoryList()
    {
      return m_pQuiz.CategoryList;
    }

    #endregion


    /// <summary>
    /// Получить произвольную картинку с сервера
    /// </summary>
    /// <returns></returns>
    public byte[] GetPicture()
    {
      return GetMetaPicture().Content;
    }

    /// <summary>
    /// Получить картинку с именем файла
    /// </summary>
    /// <returns></returns>
    public CPicture GetMetaPicture()
    {
      const string SubPath = @"$data\images";
      string sFn = this.GetType().Assembly.Location;
      string sDr = Path.GetDirectoryName(sFn);
      string sPath = Path.Combine(sDr, SubPath);
      string[] arFiles =
        Directory.GetFiles(sPath, "*.jpg", SearchOption.TopDirectoryOnly);
      int iIndex = m_pRandom.Next(0, arFiles.Length);
      string sImageFn = arFiles[iIndex];
      CPicture pP = new CPicture()
      {
        Content = File.ReadAllBytes(sImageFn),
        FileName = Path.GetFileName(sImageFn)
      };
      return pP;
    }

    public CPictureSet GetPictureSet()
    {
      const string SubPath = @"$data\images";
      string sFn = this.GetType().Assembly.Location;
      string sDr = Path.GetDirectoryName(sFn);
      string sPath = Path.Combine(sDr, SubPath);
      string[] arDirs =
        Directory.GetDirectories(sPath, "$*", SearchOption.TopDirectoryOnly);
      int iDirIndex = m_pRandom.Next(0, arDirs.Length);
      string sSetDir = arDirs[iDirIndex];


      string[] arFiles =
        Directory.GetFiles(sSetDir, "*.jpg", 
          SearchOption.TopDirectoryOnly);

      CPictureSet pPictureSet = new CPictureSet()
      {
        Title = Path.GetFileName(sSetDir)
      };
      pPictureSet.PictureList = new CPicture[arFiles.Length];
      for (int iIndex = 0; iIndex < arFiles.Length; iIndex++)
      {
        string sImageFn = arFiles[iIndex];
        pPictureSet.PictureList[iIndex] = new CPicture()
        {
          Content = File.ReadAllBytes(sImageFn),
          FileName = Path.GetFileName(sImageFn)
        };
      }
      return pPictureSet;

    }
  }
}