using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi182_20190925_classes.Storage
{
  /// <summary>
  /// Игра
  /// </summary>
  public class CGame
  {
    #region constructors
    /// <summary>
    /// КОнструктор
    /// </summary>
    public CGame()
    {
      StaticObjects = new List<CStaticObject>();
      DynamicObjects = new List<CDynamicObject>();
    }
    #endregion

    #region public properties
    /// <summary>
    /// Статические объекты
    /// </summary>
    public List<CStaticObject> StaticObjects { get; private set; }

    /// <summary>
    /// ПОлучение высоты поля
    /// </summary>
    /// <returns></returns>
    public int GetMaxY()
    {
      int iStaticMaxY =
        StaticObjects.Max(p => p.Location.Y);
      int iDynamicMaxY =
        DynamicObjects.Max(p => p.Location.Y);
      return iStaticMaxY > iDynamicMaxY
        ? iStaticMaxY
        : iDynamicMaxY;
    }

    /// <summary>
    /// ПОлучение ширины поля
    /// </summary>
    /// <returns></returns>
    public int GetMaxX()
    {
      int iStaticMaxX =
        StaticObjects.Max(p => p.Location.X);
      int iDynamicMaxX =
        DynamicObjects.Max(p => p.Location.X);
      return iStaticMaxX > iDynamicMaxX 
        ? iStaticMaxX 
        : iDynamicMaxX;
    }

    /// <summary>
    /// Динамические объекты
    /// </summary>
    public List<CDynamicObject> DynamicObjects { get; private set; }
    #endregion

    #region public methods

    /// <summary>
    /// Заполнить по номеру уровня
    /// </summary>
    /// <param name="iLevel"></param>
    public void FillStage(int iLevel)
    {
      StaticObjects.Clear();
      DynamicObjects.Clear();
      /*
      switch (iLevel)
      {
        case 1:
          h_FillStage1();
          break;
      }*/

      h_FillByFile(iLevel);

    }

    private void h_FillByFile(int iLevel)
    {
      string sFn = $"../$Data/{iLevel}.csv";
      if (!File.Exists(sFn)) return;

      string[] arLines = File.ReadAllLines(sFn);
      for (int iY = 0; iY < arLines.Length; iY++)
      {
        string[] arCells = arLines[iY].Split(';');
        for (int iX = 0; iX < arCells.Length; iX++)
        {
          string s = arCells[iX];
          // s @ iX, iY
          switch (s)
          {
            case "+":
            {
              CPlayerDynamicObject pO = 
                new CPlayerDynamicObject("Player", iX, iY);
              DynamicObjects.Add(pO);
              break;
            }
            case "*": {
              CWallStaticObject pO =
                new CWallStaticObject(iX, iY);
              StaticObjects.Add(pO);
              break;
            }
            //case "-": {
            //  CEmptyStaticObject pO =
            //    new CEmptyStaticObject(iX, iY);
            //  StaticObjects.Add(pO);
            //  break;
            //}
            case "?": {
              CBoxDynamicObject pO =
                new CBoxDynamicObject(iX, iY);
              DynamicObjects.Add(pO);
              break;
            }
            case "!": {
              CExitStaticObject pO =
                new CExitStaticObject(iX, iY);
              StaticObjects.Add(pO);
              break;
            }
          }
        }
      }
    }

    private void h_FillStage1()
    {

      CWallStaticObject pWall1 = new CWallStaticObject(0, 0);
      CWallStaticObject pWall2 = new CWallStaticObject(0, 1);
      CWallStaticObject pWall3 = new CWallStaticObject(0, 2);
      CWallStaticObject pWall4 = new CWallStaticObject(0, 3);
      StaticObjects.Add(pWall1);
      StaticObjects.Add(pWall2);
      StaticObjects.Add(pWall3);
      StaticObjects.Add(pWall4);
      ///...

    }

    /// <summary>
    /// Получить первого игрока
    /// </summary>
    /// <returns></returns>
    public CPlayerDynamicObject GetFirstPlayer()
    {
      return DynamicObjects
        .Where(p=>p is CPlayerDynamicObject)
        .Cast<CPlayerDynamicObject>()
        .FirstOrDefault();
    }
    #endregion
  }
}
