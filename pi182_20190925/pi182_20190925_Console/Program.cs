using System;

namespace pi182_20190925
{
  /// <summary>
  /// Класс приложения
  /// </summary>
  internal class Program
  {
    /// <summary>
    /// Главный метод приложения
    /// </summary>
    /// <param name="args">входные параметры команлной строки</param>
    private static void Main(String[] args)
    {
      #region variable declaration
      Int32 i1, i3 = 11;
      //i1 = 1;
      Int32 i2 = 10;
      #endregion

      // h_ShowIfElse();
      h_ShowLoops();

      h_WaitForKeyPress();
    }

    private static void h_ShowLoops()
    {
      #region for correct
      int iCount = 10;
      int jj = 0;
      for (
        int ii = 0;   // #1 инициализация цикла
        ii < iCount;  // #2 условие продложения выполнения
        ii++          // #3 выражение, которое выполняется после тела цикла на каждой итерации
      ) {
        // #4 тело цикла
        // 0 = {int jjOld = jj; jj = jj + 1; return jjOld;}
        Console.WriteLine(jj++);
        // 1 = {jj = jj + 1; return jj;}
        Console.WriteLine(++jj);
      }
      #endregion

      #region for incorrect
      int kk = 0;
      for (
        ;// #1
        true;// #2 
             // #3
      ) {
        // #4 тело цикла
        if (kk++ == 3) {
          break;  // прекратить выполнение цикла
        }
        if (kk++ == 1) {
          continue;  // перейти к следующей итерации цикла
        }
        Console.WriteLine(kk);
      }

      int ll = 1;
      for (
        ;// #1
        ((ll = ll * 3) > 100) || DateTime.Now.DayOfWeek == DayOfWeek.Monday;// #2 
        ll = ll * 3 // #3
      ) {


      }
      #endregion

    }

    private static int h_ShowIfElse()
    {
      /*
       =    присвоение
       ==   проверка на равенство
       !=   проверка неравенство
       &&   И
       ||   ИЛИ
       >, <, >=, <=
       %    Остаток от деления
       i++  постинкремент  i = i + 1
       ++i  прединкремент  i = i + 1
       */


      int i1 = 10;
      int i2 = 20;
      int i3 = 30;
      
      #region if else 
      if (i1 == 10) {
        // i1 = 10
      }
      else if (i2 != 20) {
        // i2 <> 20
      }
      else {
        // 
      }


      if ((i1 <= 10 && (i2 == 20)) || (i3 >= 30)) {
        if (i1 % 2 == 1) {
          // i1 - нечетное
        }
      }

      #endregion

      #region ?:
      /*
            //if (i1 == 10) {
            //  return i1;
            //}
            //else
            //if (i2 == 20) {
            //  return i2;
            //} else {
            //  return i3;
            //}


            //return (i1 == 10) 
            //  ? i1 
            //  : i2;
            return (i1 == 10)
              ? i1
              : (i2 == 20)
                ? i2 
                : i3;

      */
      #endregion

      return 0;
    }


    private static void h_WaitForKeyPress()
    {
      Console.WriteLine("Press any key...");

      #region comments
      // System.Xml.Schema.XmlSchema p;
      /* ConsoleKeyInfo 
         pKey =


       */
      #endregion

      Console.ReadKey();
    }
  }
}
