using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Resultado: ");
    int a = 10;
    while (a > 1)
    {
      Console.Write($"{a} ");
      a--;
    }
    Console.Write(a);
    Console.ReadKey();
  }
}
