using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi182_20190925_classes.Storage
{
  /// <summary>
  /// Абстрактный объект
  /// </summary>
  public class CObject
  {

    /// <summary>
    /// Положение объекта
    /// </summary>
    public CLocation Location;

    public CObject(int X, int Y)
    {
      Location = new CLocation(X, Y);
    }
  }
}
