using System;

namespace pi182_20190925_classes.Clock
{
  /// <summary>
  /// Часы аналоговые круглые со стрелками
  /// </summary>
  public class Clock
  {
    #region variables
    public readonly Arrow ArrowS = 
      new SecondArrow();
    public readonly Arrow ArrowM = 
      new MinuteArrow();
    public readonly Arrow ArrowH = 
      new HourArrow();

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

    #region public methods

    /// <summary>
    /// 1 сек
    /// </summary>
    public void Tick()
    {
      const int iSecondsCount = 1;

      ArrowH.Tick();
      ArrowM.Tick();
      ArrowS.Tick();
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
        ArrowH.SetAngle(ar[0]);
      }
      if (ar.Length > 1) {
        ArrowM.SetAngle(ar[1]);
      }
      if (ar.Length > 2) {
        ArrowS.SetAngle(ar[2]);
      }
    }

    /// <summary>
    /// Получает текущее время
    /// </summary>
    /// <returns></returns>
    public string GetTime()
    {
      int iHour = ArrowH.GetTime();
      int iMinute = ArrowM.GetTime();
      int iSeconds = ArrowS.GetTime();

      return $"{iHour:D2}:{iMinute:D2}:{iSeconds:D2}";
    }
    #endregion

    #region private methods

    #endregion

  }
}
