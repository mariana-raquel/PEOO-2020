using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Resultado: ");
    int a = 1;
    int s = 1;
    while (s < 10)
    {
      Console.Write($"{a} ");
      a = a + s;
      s++;
    }
    Console.Write($"{a}");
    Console.ReadKey();
  }
}
