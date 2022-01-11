 using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Resultado: ");
    int a = 1;
    while (a < 10)
    {
      Console.Write($"{a} ");
      a++;
    }
    Console.Write(a);
    Console.ReadKey();
  }
}
