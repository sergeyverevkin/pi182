using System;

namespace pi182_20190925_classes
{
  /// <summary>
  /// Часы аналоговые круглые со стрелками
  /// </summary>
  public class Clock
  {
    #region variables
    private Arrow[] ArrowArray = new Arrow[3] {
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
    /// Свойство - время
    /// </summary>
    public string Time
    {
      get {
        return GetTime();
      }
      set {
        SetTime(value);
      }
    }
    #endregion

    #region Constants
    public const double AngleMinute = 360 / 60;
    public const double AngleSecond = 360 / 60;
    public const double AngleHour = 360 / 12;
    #endregion

    #region public methods

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

    /// <summary>
    /// Устанавливает текущее время
    /// </summary>
    /// <param name="sTime"></param>
    public void SetTime(string sTime)
    {
      string[] ar = sTime.Split(':');
      int iH, iM, iS;
      if (ar.Length > 0) {
        if (Int32.TryParse(ar[0], out iH)) {
          h_SetHour(iH);
        }
      }
      if (ar.Length > 1) {
        if (Int32.TryParse(ar[1], out iM)) {
          h_SetMinute(iM);
        }
      }
      if (ar.Length > 2) {
        if (Int32.TryParse(ar[2], out iS)) {
          h_SetSeconds(iS);
        }
      }
    }
    
    /// <summary>
    /// Получает текущее время
    /// </summary>
    /// <returns></returns>
    public string GetTime()
    {
      double dSecAngle = ArrowArray[0].Angle;
      double dMinAngle = ArrowArray[1].Angle;
      double dHourAngle = ArrowArray[2].Angle;

      int iHour = (int)Math.Floor(dHourAngle / AngleHour);
      int iMinute = (int)Math.Floor(dMinAngle / AngleMinute);
      int iSeconds = (int)Math.Floor(dSecAngle / AngleSecond);

      return $"{iHour}:{iMinute}:{iSeconds}";
    }
    #endregion

    #region private methods
    private void h_SetMinute(int iM)
    {
      ArrowArray[1].Angle = AngleMinute * iM;
    }


    private void h_SetSeconds(int iS)
    {
      ArrowArray[0].Angle = AngleSecond * iS;
    }

    private void h_SetHour(int iH)
    {
      int iHReal = iH % 12;
      ArrowArray[2].Angle = iHReal * AngleHour;
    }

    #endregion

  }
}
