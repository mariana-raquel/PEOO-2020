using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int delta = (b * b) - 4 * a * c;
    if (delta < 0)
    Console.WriteLine("“impossível calcular");
    double r1 = (-b + Math.Sqrt(delta)) / 2 * a;
    double r2 = (-b - Math.Sqrt(delta)) / 2 * a;
    Console.WriteLine($"As raízes são {r1} e {r2}");
  }
}
