using System;

class MainClass {
  public static void Main (string[] args) {
    int mult;
    for (int a = 1; a <= 10; a++)
      {
        Console.WriteLine();
        Console.WriteLine($"Tabuada do {a}");
        for (int b = 1; b <= 10; b++)
        {
        mult = a * b;
        Console.WriteLine($"{a} x {b} = {mult}");
        mult = 0;
        }
      }
    Console.ReadKey();
  }
}
