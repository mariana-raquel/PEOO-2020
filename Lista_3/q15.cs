using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int maior = 0;
    int menor = 0;
    int meio = 0;

    if (a > b && a > c)
    maior = maior + a;
    if (b > a && b > c)
    maior = maior + b;
    if (c > a && c > b)
    maior = maior + c;

    if (a < b && a < c)
    menor = menor + a;
    if (b < a && b < c)
    menor = menor + b;
    if (c < a && c < b)
    menor = menor + c;

    meio = (a + b + c) - maior - menor;

    Console.WriteLine($"{menor}, {meio}, {maior}");
    
  }
}
