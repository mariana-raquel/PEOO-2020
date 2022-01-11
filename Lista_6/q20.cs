using System;

class MainClass {
  public static void Main (string[] args) {
    for (int i = 1; i <= 10; i++)
    {
      Console.Write($"{i} ");
      for (int j = 1; j <= i; j++)
      {
        if (j % 2 == 0)
          Console.Write($"{j} ");
      }
      Console.WriteLine();
    }
    Console.ReadKey();
  }
}
