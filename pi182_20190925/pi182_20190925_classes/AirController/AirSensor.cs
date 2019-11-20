using pi182_20190925_classes.AirController.Enum;

namespace pi182_20190925_classes.AirController
{
  /// <summary>
  /// Датчик
  /// </summary>
  public class AirSensor
  {

    #region public properties

    /// <summary>
    /// наименование
    /// </summary>
    public string Title;
    /// <summary>
    /// единица измерения
    /// </summary>
    public EMeasurementUnit MeasurementUnit;
    /// <summary>
    /// тип датчика(аналоговый / цифровой)
    /// </summary>
    public ESensorType SensorType;
    /// <summary>
    /// критическое значение минимальное;
    /// </summary>
    public double ThresholdMin;
    /// <summary>
    /// критическое значение максимальное;
    /// </summary>
    public double ThresholdMax;
    /// <summary>
    /// текущее значение;
    /// </summary>
    public double Value;
    /// <summary>
    /// активность(выключен / включен / неисправен).
    /// </summary>
    public EActiveState ActiveState;

    #endregion

    #region constructors

    public AirSensor(
      string title,
      EMeasurementUnit measurementUnit,
      ESensorType sensorType,
      double thresholdMin,
      double thresholdMax,
      double value,
      EActiveState activeState)
    {
      Title = title;
      MeasurementUnit = measurementUnit;
      SensorType = sensorType;
      ThresholdMin = thresholdMin;
      ThresholdMax = thresholdMax;
      Value = value;
      ActiveState = activeState;
    }

    #endregion
  }
}