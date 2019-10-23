namespace pi182_20190925_classes
{
  /// <summary>
  /// Стрелка
  /// </summary>
  public class Arrow
  {
    /// <summary>
    /// Длина, см
    /// </summary>
    public int Length;
    /// <summary>
    /// Скорость, градусов в секунду
    /// </summary>
    public double Speed;
    /// <summary>
    /// Угол поворота, градусы, от 00:00:00.
    /// </summary>
    public double Angle;


    /// <summary>
    /// 1 сек
    /// </summary>
    public void Tick()
    {
      const int iSecondsCount = 1;

      this.Angle +=
        this.Speed * iSecondsCount;
      if (this.Angle >= 360) {
        this.Angle -= 360;
      }
    }

  }
}
