// https://github.com/sergeyverevkin/pi182
using pi182_20190925_classes.Clock;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

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
      // h_ShowArrays();
      // h_ShowDictionaries();

      // h_ShowCountParts();
      // h_ShowCountVowels();
      // h_ShowCountWords();
      // h_ShowHashset();

      // h_ShowStringsEncoding();

      h_ShowClasses();

      h_WaitForKeyPress();
    }

    private static void h_ShowClasses()
    {
      /*
       2019-10-30
        Задание:
          Реализовать два класса (поля, свойства, метод)
          подключить к консольному приложению
          вызвать метод класса
        Предметные области:
          Банкнота, монета
          Телефон мобильный, телефон стационарный
          Аудитория лекционная, аудитория с компьютерами
          Автобус, Маршрутное такси
          Студент, Зачетная книжка
          Съедобный товар, несъедобный товар
          Товары в магазины
          Компьютер и монитор
          ...
       */
      Clock pC = new Clock();
      pC.SetTime("19:12:59");
      for (int ii = 0; ii < 60; ii++) {
        pC.Tick();
        Console.WriteLine(pC.GetTime());
        Thread.Sleep(1000);
      }
    }

    private static void h_ShowStringsEncoding()
    {
      Encoding encAscii = Encoding.ASCII;
      Encoding encUtf8 = Encoding.UTF8;
      Encoding encDefault = Encoding.Default;
      Encoding enc1251 = Encoding.GetEncoding(1251);

      string sDir = @"d:\1\";
      string sText = "English words и русские слова = 12";
      string[] arF = new[] {
        Path.Combine(sDir, "1.no.txt"),
        Path.Combine(sDir, "2.ascii.txt"),
        Path.Combine(sDir, "3.utf8.txt"),
        Path.Combine(sDir, "4.1251.txt"),
        Path.Combine(sDir, "5.default.txt"),
      };
      File.WriteAllText(arF[0], sText);
      File.WriteAllText(arF[1], sText, encAscii);
      File.WriteAllText(arF[2], sText, encUtf8);
      File.WriteAllText(arF[3], sText, enc1251);
      File.WriteAllText(arF[4], sText, encDefault);

      Encoding[] arEnc = new[] { Encoding.Default, Encoding.ASCII, Encoding.UTF8, enc1251 };
      foreach (string sF in arF) {
        foreach (Encoding enc in arEnc) {
          string sFileContent =
            File.ReadAllText(sF, enc);
        }
      }

    }

    private static void h_ShowHashset()
    {
      // Dictionary<int, bool> dict;
      HashSet<int> hsIntegers = new HashSet<int>();
      while (true) {
        Console.WriteLine("Enter number");
        string sS = Console.ReadLine();
        int iNum;
        if (!Int32.TryParse(sS, out iNum)) {
          break;
        }
        // 1. добавляем число пользователя
        if (!hsIntegers.Contains(iNum)) {
          hsIntegers.Add(iNum);
        }
        // 2. добавляем количество чисел, которое запросил пользователь
        for (int ii = 0; ii < iNum; ii++) {
          if (!hsIntegers.Contains(ii)) {
            hsIntegers.Add(ii);
          }
        }
      }
      Console.WriteLine("Enter searched number");
      string sS2 = Console.ReadLine();
      int iNum2;
      if (Int32.TryParse(sS2, out iNum2)) {
        bool bFound = true;
        for (int jj = 0; jj < iNum2; jj++) {
          bFound = hsIntegers.Contains(iNum2);
        }
        Console.WriteLine(
          bFound ? "ok" : "not found"
          );
      }
    }

    private static void h_ShowCountWords()
    {
      // Посчитать количество слов, встречающихся в тексте
      // больше 3 раз

      string sText = "Шла Саша по шоссе и по шоссе и по шоссе и по шоссе и сосала сушку";
      string[] arWords =
        sText.Split(new[] { ' ', ',' },
        StringSplitOptions.RemoveEmptyEntries);

      List<string> arWordsList = new List<string>();

      Dictionary<string, int> dictWordsCount =
        new Dictionary<string, int>();

      foreach (string sWord in arWords) {
        string sW = sWord.ToLower().Trim();
        if (!dictWordsCount.ContainsKey(sW)) {
          dictWordsCount[sW] = 0;
        }
        dictWordsCount[sW]++;
      }

      foreach (string sWord in dictWordsCount.Keys) {
        if (dictWordsCount[sWord] > 3) {
          arWordsList.Add(sWord);
        }
      }

      foreach (string sWord in arWordsList) {
        Console.WriteLine(sWord);
      }

    }

    private static void h_ShowCountParts()
    {
      // Посчитать количество слов со слогами "со", "са" и "су"
      string sText = "Шла Саша по шоссе и сосала сушку";
      string[] arWords =
        sText.Split(new[] { ' ', ',' },
        StringSplitOptions.RemoveEmptyEntries);
      int iCount = 0;
      foreach (string sWord in arWords) {
        int iValue = h_GetValueOfWord(sWord);
        if (iValue > 0) {
          iCount++;
        }
      }
    }

    private static void h_ShowCountVowels()
    {
      // Посчитать количество слов с тремя гласными буквами
      string sText = "Шла Саша по шоссе и сосала сушку";
      string[] arWords =
        sText.Split(new[] { ' ', ',' },
        StringSplitOptions.RemoveEmptyEntries);
      int iCount = 0;
      foreach (string sWord in arWords) {
        int iValue = h_GetValueOfVowelsCount(sWord);
        if (iValue == 3) {
          iCount++;
        }
      }
    }

    private static int h_GetValueOfVowelsCount(
      string sWord)
    {
      int iCount = 0;
      string sVowels = "уеыаоэяию";
      char[] chVowels = new[] {
        'у','е','ы','а','о','э','я',
        'и','ю' };
      //foreach (char ch in sVowels) {
      //  string sChar = ch.ToString();
      //  if (sWord.Contains(sChar)) {
      //    iCount++;
      //  }
      //}
      for (int ii = 0; ii < chVowels.Length; ii++) {
        char ch = chVowels[ii];
        for (int jj = 0; jj < sWord.Length; jj++) {
          char chWord = sWord[jj];
          if (chWord == ch) {
            iCount++;
          }
        }
      }

      return iCount;
    }

    private static int h_GetValueOfWord(string sWord)
    {
      string[] arParts = { "са", "со", "су" };
      int iCount = 0;
      foreach (string sPart in arParts) {
        int iNextIndex = -1;
        do {
          iNextIndex =
            sWord.IndexOf(
              sPart,
              iNextIndex + 1,
              StringComparison.InvariantCultureIgnoreCase
              );
          if (iNextIndex >= 0) {
            iCount++;
          }
        } while (iNextIndex >= 0);
      }
      return iCount;
    }

    private static void h_ShowDictionaries()
    {
      // (key = value) []
      Dictionary</*TKey: */string, /*TValue: */string> arDict =
        new Dictionary<string, string>() {
          { "black", "черный" },
          { "white", "белый" },
        };
      arDict["blue"] = "синий";
      arDict["red"] = "красный";
      arDict.Add("green", "зеленый");

      Dictionary<string, string>.KeyCollection arKeys =
        arDict.Keys;

      foreach (string sKey in arKeys) {
        Console.WriteLine($"{sKey} = {arDict[sKey]}");
      }

      string sText = "Those Red roses seems to be white enough";
      string[] arWords =
        sText.Split(new[] { ' ', ',' },
        StringSplitOptions.RemoveEmptyEntries);
      List<string> arWordList = new List<string>();
      //for (int ii = 0; ii < arWords.Length; ii++) {
      //  string sWord = arWords[ii];
      //  // ...
      //}
      foreach (string sWord in arWords) {
        string sWordLower = sWord.ToLower();
        arWordList.Add(
          arDict.ContainsKey(sWordLower)
          ? arDict[sWordLower]
          : sWord
        );
      }

      Console.WriteLine(String.Join(" ", arWordList));
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
        int[] ar0 = new int[iP];
        int iSum3 = 0;
        for (int ii = 0; ii < ar0.Length; ii++) {
          ar0[ii] = ii;
          // ...
          int iPP = ar0[ii];
          iSum3 += iPP;
        }
        Console.WriteLine(iSum3);
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
      List<string> ar = new List<string>();
      ar.Add("qweq");
      ar.Clear();
      ar.Add("1");
      ar.Remove("qweq");
      ar.RemoveAt(0);
      ar.Insert(0, "asasd");
      int iSum2 = 0;
      for (int ii = 0; ii < ar.Count; ii++) {
        string sPP = ar[ii];
        iSum2 += sPP.Length;
      }
      Console.WriteLine(iSum2);

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
