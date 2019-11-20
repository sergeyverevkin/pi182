using System.Collections.Generic;
using pi182_20190925_classes.AirController.Enum;

namespace pi182_20190925_classes.AirController
{
  /// <summary>
  /// Анализатор воздуха
  /// - датчик(массив)
  /// </summary>
  public class AirController
  {
    #region private variables
    private List<AirSensor> m_arAirSensors;
    #endregion

    #region constructors
    public AirController()
    {
      m_arAirSensors = new List<AirSensor>();
    }
    #endregion

    /// <summary>
    /// Список сенсоров
    /// </summary>
    public List<AirSensor> Sensors => m_arAirSensors;

    #region public methods


    /// <summary>
    /// Добавить датчик
    /// </summary>
    /// <param name="pAirSensor"></param>
    public void AddSensor(AirSensor pAirSensor)
    {
      m_arAirSensors.Add(pAirSensor);
    }

    #endregion

  }

  /// <summary>
  /// Тестовый анализатор воздуха
  /// </summary>
  public class TestAirController: AirController {
    public TestAirController(): base()
    {
      AirSensor pTempSensor = new AirSensor(
        "Термометр №1", EMeasurementUnit.Degree,
        ESensorType.Analog, 18, 28, 20, EActiveState.Disable);
      AddSensor(pTempSensor);

      AirSensor pMetanSensor = new AirSensor(
        "Датчик метана №1", EMeasurementUnit.Density,
        ESensorType.Digital, 0, 2, 10, EActiveState.Disable);
      AddSensor(pMetanSensor);

      AirSensor pTempSensor2 = new AirSensor(
        "Термометр №2", EMeasurementUnit.Degree,
        ESensorType.Digital, 16, 30, 20, EActiveState.Disable);
      AddSensor(pTempSensor2);

    }
  }

}
