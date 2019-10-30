using System;

namespace pi182_20190925_classes
{
  /// <summary>
  /// Стрелка
  /// </summary>
  public class Arrow
  {
    /// <summary>
    /// Поле: Длина, см
    /// </summary>
    public int Length;

    /// <summary>
    /// свойство (Автосвойство): 
    /// Скорость, градусов в секунду
    /// </summary>
    public double Speed { get; set; }

    /// <summary>
    /// Угол поворота, градусы, от 00:00:00.
    /// </summary>

    // Поле: угол
    private double _angle;
    /// <summary>
    /// Свойство: угол
    /// </summary>
    public double Angle
    {
      get {
        double dExtAngle = _angle;
        while (dExtAngle < 0) {
          dExtAngle += 360;
        }
        while (dExtAngle >= 360) {
          dExtAngle -= 360;
        }
        return dExtAngle;
      }
      set {
        //if (value > 360 || value < 0)
        //  throw new Exception("angle is not correct");
        _angle = value;
      }
    }

    /// <summary>
    /// 1 сек
    /// </summary>
    public void Tick()
    {
      const int iSecondsCount = 1;

      this.Angle = this.Angle + 
        this.Speed * iSecondsCount;
      if (this.Angle >= 360) {
        this.Angle -= 360;
      }
    }

  }
}
