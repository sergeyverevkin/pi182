namespace pi182_20190925_classes.Storage
{
  /// <summary>
  /// СтатическийОбъект
  /// </summary>
  public class CStaticObject : CObject
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    public CStaticObject(int X, int Y) : base(X, Y)
    {
    }
  }

  /// <summary>
  /// Стена: СтатическийОбъект
  /// </summary>
  public class CWallStaticObject : CStaticObject
  {
    public CWallStaticObject(int X, int Y) : base(X, Y)
    {
    }
  }

  /*
  /// <summary>
  /// Свободное поле: СтатическийОбъект
  /// </summary>
  public class CEmptyStaticObject : CStaticObject
  {
    public CEmptyStaticObject(int X, int Y) : base(X, Y)
    {
    }
  }
  */

  /// <summary>
  /// Зона выхода: СтатическийОбъект
  /// </summary>
  public class CExitStaticObject : CStaticObject
  {
    public CExitStaticObject(int X, int Y) : base(X, Y)
    {
    }
  }

}