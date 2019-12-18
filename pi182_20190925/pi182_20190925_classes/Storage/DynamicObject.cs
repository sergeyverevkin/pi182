namespace pi182_20190925_classes.Storage
{
  /// <summary>
  /// ПеремещающийсяОбъект
  /// </summary>
  public class CDynamicObject : CObject
  {
    // 
    public CDynamicObject(int X, int Y) : base(X, Y)
    {
    }
  }


  /// <summary>
  /// Игрок: ПеремещающийсяОбъект
  /// </summary>
  public class CPlayerDynamicObject : CDynamicObject
  {
    public CPlayerDynamicObject(string name, int X, int Y): base(X, Y)
    {
      Name = name;
    }

    /// <summary>
    /// Имя игрока
    /// </summary>
    public string Name { get; set; }
  }


  /// <summary>
  /// Ящик: ПеремещающийсяОбъект
  /// </summary>
  public class CBoxDynamicObject : CDynamicObject
  {
    public CBoxDynamicObject(int X, int Y) : base(X, Y)
    {
    }
  }

}