// https://github.com/sergeyverevkin/pi182
using System;
using System.Collections;

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
      // h_ShowLoops();
      h_ShowArrays();

      h_WaitForKeyPress();
    }

    private static void h_ShowArrays()
    {
      //var X;
      //var XX = new[] { XXX1, XXX2, XXX3 };
      //@XXX1 = XXX;
      // 1. Статические массивы
      int[] ar1 =
        new int[4]
        { 1, 2, 34, 5 };
      int[] ar2 = new int[4];
      // индекс начинается с нуля
      ar2[0] = 1;
      // ar2[1] = default(int);

      int[] ar3 = null;
      ar3 = new[] {
        1,
        2,
        3,
        3,
        3,
        3,
        45 };

      Console.WriteLine("Enter item count");
      string sLine = Console.ReadLine();
      int iP;
      if (Int32.TryParse(sLine, out iP)) {
        int[] ar = new int[iP];
        int iSum2 = 0;
        for (int ii = 0; ii < ar.Length; ii++) {
          ar[ii] = ii;
          // ...
          int iPP = ar[ii];
          iSum2 += iPP;
        }
        Console.WriteLine(iSum2);
      }

      // 2. Динамические массивы: нетипизированные
      // new ArrayList();
      ArrayList arList1 = new ArrayList();
      arList1.Add(10);
      arList1.Add("10@2");
      arList1.Add(DateTime.Now);
      arList1.Insert(0, "qweqw");
      arList1.RemoveAt(1);
      arList1.Remove("qweqw");
      arList1.Clear();
      int iSum = 0;
      for (int ii = 0; ii < arList1.Count; ii++) {
        object iPP = arList1[ii];
        if (iPP is int) {
          iSum += (int)iPP;
        }
      }
      Console.WriteLine(iSum);

      // 3. Динамические массивы: типизированные
      // foreach
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

      #region while
      // цикл с предусловием
      int i2 = 0;
      while (i2 < 10) {
        // 
        i2++;
      }


      // вечный цикл
      //while (true) {
      //  // 
      //}
      // никогда не зайдем
      //while (false) {
      //  // 
      //}

      // цикл с постусловием
      int ii2 = 10;
      do {
        ii2++;
      } while (ii2 < 20);

      // выполнится один раз
      //do {
      //  ii++;
      //} while (false);

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
