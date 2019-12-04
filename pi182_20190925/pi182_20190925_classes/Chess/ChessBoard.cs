using System.Collections.Generic;

/*
 *  
 *  
 *  
 *  Книга рецептов
 *  
 *  1. Книга рецептов
 *   - рецепты (массив)
 *   - владелец
 *   
 *  2. Рецепт
 *   - название
 *   - ингриденты (массив)
 *   - описание
 *   
 *  3. Ингридиенты
 *    - название
 *    - цвет
 *   
 *   3.1. Жидкий ингридиент (наследний от ингридиента)
 *    - плотность
 *    - объем
 *    
 *   3.2. Сыпучий ингридиент (наследний от ингридиента)
 *    - масса
 *    
 *    
 *    
 */







/*
 * Шахматы
 *    
 *  1. Шахматная доска
 *    - полей[]
 *    
 *  2. Поле шахматной доски
 *    - цвет
 *    - координаты
 *    - фигура
 *    
 *  3. Фигура поля шахматной доски
 *    - тип фигуры
 *    - цвет фигуры
 *    
 *  3.1. Конь - фигура (наследник)
 *  3.2. Пешка - фигура (наследник)
*/
namespace pi182_20190925_classes.Chess
{
  public class ChessBoard
  {
    #region private members

    public const int Width = 8;
    public const int Height = 8;

    public List<Field> Fields { get; }
    #endregion


    #region constructors

    public ChessBoard()
    {
      Fields = new List<Field>();
      h_Fill();
      h_FillFigures();
    }

    #endregion


    private Field h_FindField(int X, int Y)
    {
      for (int ii = 0; ii < Fields.Count; ii++) {
        Field pF = Fields[ii];
        if (pF.IsPosition(X, Y)) {
          return pF;
        }
      }
      return null;
    }

    private void h_FillFigures()
    {
      for (int ii = 0; ii < Width; ii++) {
        SimpleChessFigure pFig = new SimpleChessFigure(EChessColor.White);
        Field pF = h_FindField(ii, 1);
        if (pF != null) {
          pF.Figure = pFig;
        }
      }
      for (int ii = 0; ii < Width; ii++) {
        SimpleChessFigure pFig = new SimpleChessFigure(EChessColor.Black);
        h_SetFigure(pFig, ii, 6);
      }

      HorseChessFigure pHorseFig1 = new HorseChessFigure(EChessColor.Black);
      h_SetFigure(pHorseFig1, 1, 7);
      HorseChessFigure pHorseFig2 = new HorseChessFigure(EChessColor.Black);
      h_SetFigure(pHorseFig2, 6, 7);

    }

    private void h_SetFigure(ChessFigure pFig, int iX, int iY)
    {
      Field pF = h_FindField(iX, iY);
      if (pF != null) {
        pF.Figure = pFig;
      }
    }

    private void h_Fill()
    {
      for (int ii = 0; ii < Width; ii++) {
        for (int jj = 0; jj < Height; jj++) {
          // 0 0: черное
          // 0 1: белое
          // 1 0: белое
          // 1 1 черное
          EChessColor enC = ((ii + jj) % 2 == 1)
            ? EChessColor.White
            : EChessColor.Black;

          Coord pP = new Coord(ii, jj);
          Field pF = new Field(enC, pP, null);
          Fields.Add(pF);
        }
      }
    }
  }
}
