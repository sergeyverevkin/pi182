namespace pi182_20190925_classes.Chess
{
  /// <summary>
  /// Поле
  /// </summary>
  public class Field
  {

    #region public properties

    /// <summary>
    /// - цвет
    /// </summary>
    public EChessColor Color { get; }
    //    - координаты
    public Coord Position { get; }
    //    - фигура
    public ChessFigure Figure { get; set; }

    #endregion

    #region constructors
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="color"></param>
    /// <param name="position"></param>
    /// <param name="figure"></param>
    public Field(EChessColor color, Coord position, ChessFigure figure)
    {
      Color = color;
      Position = position;
      Figure = figure;
    }

    #endregion

    #region public methods

    /// <summary>
    /// Моя ли позиция
    /// </summary>
    /// <param name="iX"></param>
    /// <param name="iY"></param>
    /// <returns></returns>
    public bool IsPosition(int iX, int iY)
    {
      return (Position.X == iX && Position.Y == iY);
    }

    #endregion
  }
}