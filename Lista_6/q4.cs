using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Resultado: ");
    int a = 1;
    int s = 1;
    int b;
    while (a < 30)
    {
      if (a % 3 == 0)
        b = a * (-s);
      else
      b = a * s;
      
      Console.Write($"{b} ");
      a = a + 1;
    }
    b = a * (-s);
    Console.Write(b);
    Console.ReadKey();
  }
}
