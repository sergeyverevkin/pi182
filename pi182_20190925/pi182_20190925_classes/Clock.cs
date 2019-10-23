namespace pi182_20190925_classes
{
  /// <summary>
  /// Часы аналоговые круглые со стрелками
  /// </summary>
  public class Clock
  {
    public Arrow[] ArrowArray = new Arrow[3] {
      new Arrow() {
        Angle = 0,
        Length = 10,
        Speed = 6,
      },
      new Arrow() {
        Angle = 0,
        Length = 8,
        Speed = 0.1,
      },
      new Arrow() {
        Angle = 0,
        Length = 5,
        Speed = 1 / 120
      },
    };

    /// <summary>
    /// 1 сек
    /// </summary>
    public void Tick()
    {
      const int iSecondsCount = 1;

      foreach (Arrow ar in ArrowArray) {
        ar.Tick();
      }
    }
  }
}
