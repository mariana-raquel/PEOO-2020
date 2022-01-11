using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Resultado: ");
    int a = 1;
    int s = 0;
    while (a <= 30)
    {
      Console.Write($"{a} ");
      if (a % 3 == 0)
      {
        s += a + a-1 + a-2;
        Console.Write($"{s} ");
        s = 0;
      }
      a++;
    }
    Console.ReadKey();
  }
}
