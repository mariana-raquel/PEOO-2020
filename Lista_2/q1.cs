using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite dois valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a > b) Console.WriteLine($"Maior = {a}");
    if (b > a) Console.WriteLine($"Maior = {b}");
    if (a == b) Console.WriteLine("Números iguais");
  }
}
