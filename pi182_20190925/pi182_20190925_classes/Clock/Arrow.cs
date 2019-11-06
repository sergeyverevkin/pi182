using System;

namespace pi182_20190925_classes.Clock
{
  /// <summary>
  /// Стрелка
  /// </summary>
  public class Arrow
  {
    #region consts
    public const double AngleMinute = 360 / 60;
    public const double AngleSecond = 360 / 60;
    public const double AngleHour = 360 / 12;
    #endregion

    #region constructor
    protected Arrow(
      int length,
      double speed,
      double angle = 0)
    {
      Length = length;
      Speed = speed;
      Angle = angle;
    }
    #endregion

    #region variables: fields and properties
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
    #endregion

    #region methods

    /// <summary>
    /// Количество единиц измерения для текущей стрелки
    /// </summary>
    /// <returns></returns>
    public int GetTime()
    {
      // TODO: полиморфизм (виртуальный метод)
      double dAnglePerUnit = 0;
      if (this is SecondArrow) {
        dAnglePerUnit = AngleSecond;
      }
      else
      if (this is MinuteArrow) {
        dAnglePerUnit = AngleMinute;
      }
      else
      if (this is HourArrow) {
        dAnglePerUnit = AngleHour;
      }
      else throw new Exception("Неизвестный вид стрелки");

      return (int)Math.Floor(Angle / dAnglePerUnit);
    }

    /// <summary>
    /// Установить угол стрелки по количество ее единиц
    /// </summary>
    /// <param name="sTime"></param>
    public void SetAngle(string sTime)
    {
      int iTime;
      if (!Int32.TryParse(sTime, out iTime)) {
        return;
      }

      // TODO: полиморфизм (виртуальный метод)
      if (this is SecondArrow) {
        Angle = AngleSecond * iTime;
      }
      else
      if (this is MinuteArrow) {
        Angle = AngleMinute * iTime;
      }
      else
      if (this is HourArrow) {
        int iHReal = iTime % 12;
        Angle = iHReal * AngleHour;
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
    #endregion

  }
}
