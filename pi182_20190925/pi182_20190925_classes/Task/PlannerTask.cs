using System;

namespace pi182_20190925_classes.Task
{
  /// <summary>
  /// Задание
  /// - текст
  /// - срочность
  /// - дата окончания
  /// - состояние
  /// </summary>
  public class PlannerTask
  {
    /// <summary>
    /// текст
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// срочность
    /// </summary>
    public EPriority Priority { get; set; }
    /// <summary>
    /// дата окончания
    /// </summary>
    public DateTime DateEnd { get; set; }
    /// <summary>
    /// состояние
    /// </summary>
    public EState State { get; set; }
    /// <summary>
    /// статус
    /// </summary>
    public EProcess Process { get; set; }

    public PlannerTask(string text, EPriority priority, DateTime dateEnd, EState state, EProcess process)
    {
      Text = text;
      Priority = priority;
      DateEnd = dateEnd;
      State = state;
      Process = process;

      // установка нескольких флагов
      Process = EProcess.ResourceDepleted | EProcess.Pending;
      // проверка включенного флага
      if (Process.HasFlag(EProcess.ResourceDepleted))
      {
        // включен
      }
    }
  }
}