// Decompiled with JetBrains decompiler
// Type: HomeWork_7.Program
// Assembly: HomeWork_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A53F447D-AEDC-40AD-9B97-A4B4E98BC993
// Assembly location: C:\Users\Администратор\source\repos\Практические работы\HomeWork_7\bin\Release\net5.0\HomeWork_7.dll

using System;

namespace HomeWork_7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Введи строку и она запишется в обратном порядке: ");
      string str = Console.ReadLine();
      string empty = string.Empty;
      for (int index = str.Length - 1; index > -1; --index)
        empty += str[index].ToString();
      Console.WriteLine(empty);
    }
  }
}
