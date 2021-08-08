using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite quatro valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int pares = 0;
    int impares = 0;
    if (a % 2 == 0)
    pares = pares + a;
    else
    impares = impares + a;
    if (b % 2 == 0)
    pares = pares + b;
    else
    impares = impares + b;
    if (c % 2 == 0)
    pares = pares + c;
    else
    impares = impares + c;
    if (d % 2 == 0)
    pares = pares + d; 
    else
    impares = impares + d;

    Console.WriteLine($"Soma dos pares = {pares}");
    Console.WriteLine($"Soma dos ímpares = {impares}");
  }
}
