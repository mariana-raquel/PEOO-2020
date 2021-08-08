using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int menor = 0;
    int maior = 0;
    int soma = 0;
    if (a < b && a < c && a < d)
    menor = menor + a;
    if (b < a && b < c && b < d)
    menor = menor + b;
    if (c < a && c < b && c < d)
    menor = menor + c;
    if (d < a && d < b && d < c)
    menor = menor + d;
    if (a > b && a > c && a > d)
    maior = maior + a;
    if (b > a && b > c && b > d)
    maior = maior + b;
    if (c > a && c > b && c > d)
    maior = maior + c;
    if (d > a && d > b && d > c)
    maior = maior + d;
    if (maior == a && menor == b)
    soma = soma + c + d;
    if (maior == a && menor == c)
    soma = soma + d + b;
    if (maior == a && menor == d)
    soma = soma + c + b;
    if (maior == b && menor == a)
    soma = soma + c + d;
    if (maior == b && menor == c)
    soma = soma + a + d;
    if (maior == b && menor == d)
    soma = soma + c + a;
    if (maior == c && menor == a)
    soma = soma + b + d;
    if (maior == c && menor == b)
    soma = soma + a + d;
    if (maior == c && menor == d)
    soma = soma + a + b;
    if (maior == d && menor == a)
    soma = soma + c + b;
    if (maior == d && menor == b)
    soma = soma + c + a;
    if (maior == d && menor == c)
    soma = soma + a + b;
    Console.WriteLine($"Maior valor = {maior}");
    Console.WriteLine($"Menor valor = {menor}");
    Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
  }
}
