using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe quatro valores inteiros diferentes");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int menor1 = 0;
    int menor2 = 0;
    int soma = 0;

    if (a < b && a < c && a < d && b < c && b < d)
    {
      menor1 = menor1 + a;
      menor2 = menor2 + b;
    }
     if (a < b && a < c && a < d && c < b && c < d)
    {
      menor1 = menor1 + a;
      menor2 = menor2 + c;
    }
     if (a < b && a < c && a < d && d < b && d < c)
    {
      menor1 = menor1 + a;
      menor2 = menor2 + d;
    }


    if (b < a && b < c && b < d && a < c && a < d)
    {
      menor1 = menor1 + b;
      menor2 = menor2 + a;
    }
     if (b < a && b < c && b < d && c < a && c < d)
    {
      menor1 = menor1 + b;
      menor2 = menor2 + c;
    }
     if (b < a && b < c && b < d && d < a && d < c)
    {
      menor1 = menor1 + b;
      menor2 = menor2 + d;
    }


    if (c < a && c < b && c < d && a < b && a < d)
    {
      menor1 = menor1 + c;
      menor2 = menor2 + a;
    }
     if (c < a && c < b && c < d && b < a && b < d)
    {
      menor1 = menor1 + c;
      menor2 = menor2 + b;
    }
     if (c < a && c < b && c < d && d < a && d < b)
    {
      menor1 = menor1 + c;
      menor2 = menor2 + d;
    }


    if (d < a && d < b && d < c && a < b && a < c)
    {
      menor1 = menor1 + d;
      menor2 = menor2 + a;
    }
     if (d < a && d < b && d < c && b < a && b < c)
    {
      menor1 = menor1 + d;
      menor2 = menor2 + b;
    }
     if (d < a && d < b && d < c && c < a && c < a)
    {
      menor1 = menor1 + d;
      menor2 = menor2 + c;
    }

    soma = soma + (menor1 + menor2);
    Console.WriteLine($"A soma dos dois menores valores é {soma}");
  }
}
