namespace pi182_20190925_classes.Chess
{
  /// <summary>
  /// Шахматной фигуры
  /// </summary>
  public class ChessFigure
  {
    #region public properties

    /// <summary>
    /// Цвет фигуры
    /// </summary>
    public EChessColor Color { get; }
    

    #endregion

    #region constructors

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="color"></param>
    public ChessFigure(EChessColor color)
    {
      Color = color;
    }

    #endregion
  }
}