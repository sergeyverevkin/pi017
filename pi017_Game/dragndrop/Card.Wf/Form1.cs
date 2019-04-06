using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Card.Wf
{
  public partial class Form1 : Form
  {
    /// <summary>
    /// Типы карты
    /// </summary>
    internal enum ECardType
    {
      Num1 = 1,
      Num2 = 2,
      Num3 = 3
    }

    /// <summary>
    /// Карта в игре
    /// </summary>
    internal class CCard
    {
      /// <summary>
      /// Value
      /// </summary>
      public ECardType Value { get; set; }

      /// <summary>
      /// .ctor
      /// </summary>
      /// <param name="iValue"></param>
      public CCard(ECardType iValue)
      {
        Value = iValue;
      }
    }

    /// <summary>
    /// КОллекция карт в игре
    /// </summary>
    internal class CCardCollection
    {
      /// <summary>
      /// Cards
      /// </summary>
      public List<CCard> Cards
      {
        get { return _cards; }
      }

      private Random m_pRandom = new Random();
      private List<CCard> _cards = new List<CCard>();

      /// <summary>
      /// .ctor
      /// </summary>
      /// <param name="iCount"></param>
      public CCardCollection(int iCount)
      {
        for (int ii = 0; ii < iCount; ii++)
        {
          // int i = h_GetRandom(new int[] {1, 2, 3, 54});

          CCard pC = new CCard(
            h_GetRandom(new[] {
                ECardType.Num1,
                ECardType.Num2,
                ECardType.Num3
            }));
          _cards.Add(pC);
        }
      }

      //private int h_GetRandom32873455345345345(int[] enC)
      //{
      //  // ...
      //}


      private 
        TMyTypeOfElement 
        h_GetRandom<TMyTypeOfElement>(
        TMyTypeOfElement[] enCardType)
      {
        int iV = m_pRandom.Next(0, enCardType.Length);
        return enCardType[iV];
      }

    }

    /// <summary>
    /// Класс игры
    /// </summary>
    internal class CGame
    {
      public CGame(int iCardCount)
      {
        _collection = new CCardCollection(iCardCount);
      }


      private CCardCollection _collection;

      public CCardCollection Collection
      {
        get { return _collection; }
      }
    }


    /// <summary>
    /// CCardAtTable (карта "на столе" (с позицией))
    /// </summary>
    internal class CCardAtTable
    {
      public int X { get; set; }
      public int Y { get; set; }
      public CCard Card { get; set; }

      /// <summary>
      /// .ctor
      /// </summary>
      /// <param name="pCard"></param>
      public CCardAtTable(CCard pCard)
      {
        Card = pCard;
      }
    }

    /// <summary>
    /// Коллекция карт "на столе"
    /// </summary>
    internal class CCardAtTableCollection
    {
      private ECardType h_GetRandom(ECardType[] enCardType)
      {
        int iV = m_pRandom.Next(0, enCardType.Length);
        return enCardType[iV];
      }

      /// <summary>
      /// Cards
      /// </summary>
      public List<CCardAtTable> Cards
      {
        get { return _cards; }
      }

      private readonly Random m_pRandom = new Random();
      private List<CCardAtTable> _cards = new List<CCardAtTable>();

      public CCardAtTableCollection(
        CCardCollection pCardCollection,
        int iTableWidth,
        int iTableHeight,
        int iCardWidth,
        int iCardHeight)
      {
        for (int ii = 0; ii < pCardCollection.Cards.Count; ii++)
        {
          CCardAtTable pC = new CCardAtTable(pCardCollection.Cards[ii]);
          pC.X = m_pRandom.Next(0, iTableWidth - iCardWidth);
          pC.Y = m_pRandom.Next(0, iTableHeight - iCardHeight);
          _cards.Add(pC);
        }
      }
    }








    private CGame m_pGame;
    private CCardAtTableCollection m_pCardsAtTable;

    /// Для хранения переносимого объекта
    private CCardAtTable _card;
    private int _deltaX, _deltaY;
    /// -------------------------------------

    private const int CardWidth = 50;
    private const int CardHeight = 100;
    private const int CardCount = 30;

    public Form1()
    {
      InitializeComponent();

      m_pGame = new CGame(CardCount);
      m_pCardsAtTable = new CCardAtTableCollection(
        m_pGame.Collection,
        pictureBox1.Width, pictureBox1.Height,
        CardWidth, CardHeight);

    }

    private void pictureBox1_MouseDown(
      object sender,
      MouseEventArgs e)
    {
      h_FindCard(e.X, e.Y);
    }

    private bool h_FindCard(int iX, int iY)
    {
      for (
        int ii = m_pCardsAtTable.Cards.Count - 1; 
        ii >= 0; 
        ii--)
      {
        int iX1 = m_pCardsAtTable.Cards[ii].X;
        int iY1 = m_pCardsAtTable.Cards[ii].Y;
        int iX2 = iX1 + CardWidth;
        int iY2 = iY1 + CardHeight;
        if (
          (iX > iX1) && (iX < iX2) && 
          (iY > iY1) && (iY < iY2))
        {
          _deltaX = iX - iX1;
          _deltaY = iY - iY1;
          _card = m_pCardsAtTable.Cards[ii];
          return true;
        }
      }

      return false;
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      _card = null;
    }

    private void pictureBox1_Paint(
      object sender, 
      PaintEventArgs e)
    {
      Brush pTextBrush = Brushes.Black;
      for (int ii = 0; ii < m_pCardsAtTable.Cards.Count; ii++)
      {
        CCardAtTable p = m_pCardsAtTable.Cards[ii];
        Pen pP = h_CreatePen(p.Card.Value);
        Brush pB = h_CreateBrush(p.Card.Value);
        e.Graphics.DrawRectangle(pP, p.X, p.Y, CardWidth, CardHeight);
        e.Graphics.FillRectangle(pB, p.X, p.Y, CardWidth, CardHeight);
        e.Graphics.DrawString($"{ii}", DefaultFont, pTextBrush, 
          p.X + 10, p.Y + 10);
      }
    }

    private Pen h_CreatePen(ECardType cardValue)
    {
      return new Pen(Color.Black);
    }

    private Brush h_CreateBrush(ECardType cardValue)
    {
      
      switch (cardValue) {
        case ECardType.Num1:
          return Brushes.CadetBlue;
        case ECardType.Num2:
          return Brushes.Coral;
        case ECardType.Num3:
          return Brushes.DarkViolet;
        default:
          throw new ArgumentOutOfRangeException("cardValue", cardValue, null);
      }
    }

    private void pictureBox1_MouseMove(
      object sender, 
      MouseEventArgs e)
    {
      if (_card == null) return;
      _card.X = e.X - _deltaX;
      _card.Y = e.Y - _deltaY;
      pictureBox1.Invalidate();
    }
  }
}
