namespace pi182_20190925_classes.Storage
{

  /// <summary>
  /// Координата
  /// </summary>
  public class CLocation
  {
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public CLocation(int x, int y)
    {
      X = x;
      Y = y;
    }

    /// <summary>
    /// Положение по горизонтали
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Положение по вертикали
    /// </summary>
    public int Y { get; set; }
  }
}