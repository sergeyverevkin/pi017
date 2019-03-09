using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComparePic.Classes
{
  public class CDbGame
  {
    /// <summary>
    /// .ctor
    /// </summary>
    public CDbGame()
    {
      PictureList = new List<CPicturePair>();
    }

    /// <summary>
    /// Изображения в БД
    /// </summary>
    public List<CPicturePair> PictureList { get; private set; }

    /// <summary>
    /// Загрузка из директории информации о возможных заданиях
    /// </summary>
    /// <param name="sFolder"></param>
    public void Load(string sFolder)
    {
      string[] arDirs =
        Directory.GetDirectories(sFolder, "$*");
      foreach (string sDir in arDirs) {
        h_LoadDirectory(sDir);
      }

    }

    private void h_LoadDirectory(string sDir)
    {
      string[] arF = Directory.GetFiles(sDir, 
        "*.txt");
      if (arF.Length == 0) return;
      string sTxtFn = arF[0];

      CPicturePair pPair = new CPicturePair();
      string sShortDir = Path.GetFileName(sDir);
      pPair.Id = Int32.Parse(sShortDir.Substring(1));
      h_ParseFile(sTxtFn, pPair);      
    }

    private void h_ParseFile(string sTxtFn, CPicturePair pPair)
    {
      using (Stream pFs = File.OpenRead(sTxtFn)) {
        using (StreamReader pSr = new StreamReader(pFs, Encoding.GetEncoding(1251))) {
          pPair.Uri = h_GetNextLine(pSr);
          pPair.Title = h_GetNextLine(pSr);
          string sP1 = h_GetNextLine(pSr); // 0;0
          string[] arParts = sP1.Split(';'); // "0", "0"
          if (arParts.Length != 2) return;
          pPair.Picture1 = new CCoord(arParts[0], arParts[1]);
          string sP2 = h_GetNextLine(pSr); // 0;0
          arParts = sP2.Split(';'); // "0", "0"
          if (arParts.Length != 2) return;
          pPair.Picture2 = new CCoord(arParts[0], arParts[1]);
          while (!pSr.EndOfStream) {
            string sArea = h_GetNextLine(pSr);
            pPair.AreaList.Add(new CArea(sArea));
          }
        }
      }
    }
    private string h_GetNextLine(StreamReader pSr)
    {
      while (!pSr.EndOfStream) {
        string sLine = pSr.ReadLine().Trim();
        if (sLine.StartsWith("#")) continue;
        return sLine;
      }
      return null;
    }


    /// <summary>
    /// Загрузка из директории информации о возможных заданиях
    /// </summary>
    /// <param name="sFolder"></param>
    /// <param name="pPair"></param>
    public void Save(string sFolder, CPicturePair pPair)
    {
      // TODO
    }

    /// <summary>
    /// Загрузка из директории информации о возможных заданиях
    /// </summary>
    /// <param name="sFolder"></param>
    /// <param name="iPicturePairId"></param>
    public void Delete(string sFolder, int iPicturePairId)
    {
      // TODO
    }
  }
}
