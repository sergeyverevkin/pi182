using System;

namespace pi182_20190925_classes.Task
{
  /// <summary>
  /// Флаги процесса выполнения
  /// 0000 0001 - 1
  /// 0000 0010 - 2
  /// 0000 0100 - 4
  /// 0000 0111 - 7
  /// </summary>
  [Flags]
  public enum EProcess: byte
  {
    /// <summary>
    /// Пока не выходит
    /// </summary>
    Broken = 1 << 0,
    /// <summary>
    /// Ждем внешней помощи
    /// </summary>
    Pending = 1 << 1,
    /// <summary>
    /// Не хватает денег
    /// </summary>
    ResourceDepleted = 1 << 2,
    /// <summary>
    /// Не хватает денег + Ждем внешней помощи + Пока не выходит
    /// </summary>
    AllActive = ResourceDepleted | Pending | Broken
  }
}