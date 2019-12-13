using System.Collections.Generic;

namespace pi182_20190925_classes.Task
{
  /// <summary>
  /// Ежедневник
  /// - владелец
  /// - задание[]
  /// </summary>
  public class Planner
  {
    #region Публичные свойства
    public string Owner { get; set; }
    public List<PlannerTask> TaskList { get; }


    #endregion
    #region Конструкторы

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="owner"></param>
    public Planner(string owner)
    {
      Owner = owner;
      TaskList = new List<PlannerTask>();
    }

    #endregion
  }
}
