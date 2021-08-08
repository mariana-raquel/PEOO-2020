using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite dez valores inteiros");
    string[] valor = Console.ReadLine().Split(' ');
    int a = int.Parse(valor[0]);
    int b = int.Parse(valor[1]);
    int c = int.Parse(valor[2]);
    int d = int.Parse(valor[3]);
    int e = int.Parse(valor[4]);
    int f = int.Parse(valor[5]);
    int g = int.Parse(valor[6]);
    int h = int.Parse(valor[7]);
    int i = int.Parse(valor[8]);
    int j = int.Parse(valor[9]);
    int maior = 0;
    int menor = 0;
    if (a > b && a > c && a > d && a > e && a > f && a > g && a > h && a > i && a > j)
    maior = maior + a;
    if (b > a && b > c && b > d && b > e && b > f && b > g && b > h && b > i && b > j)
    maior = maior + b;
    if (c > a && c > b && c > d && c > e && c > f && c > g && c > h && c > i && c > j)
    maior = maior + c;
    if (d > a && d > b && d > c && d > e && d > f && d > g && d > h && d > i && d > j)
    maior = maior + d;
    if (e > a && e > b && e > c && e > d && e > f && e > g && e > h && e > i && e > j)
    maior = maior + e;
    if (f > a && f > b && f > c && f > d && f > e && f > g && f > h && f > i && f > j)
    maior = maior + f;
    if (g > a && g > b && g > c && g > d && g > e && g > f && g > h && g > i && g > j)
    maior = maior + g;
    if (h > a && h > b && h > c && h > d && h > e && h > f && h > g && h > i && h > j)
    maior = maior + h;
    if (i > a && i > b && i > c && i > d && i > e && i > f && i > g && i > h && i > j)
    maior = maior + i;
    if (j > a && j > b && j > c && j > d && j > e && j > f && j > g && j > h && j > i)
    maior = maior + j;

    if (a < b && a < c && a < d && a < e && a < f && a < g && a < h && a < i && a < j)
    menor = menor + a;
    if (b < a && b < c && b < d && b < e && b < f && b < g && b < h && b < i && b < j)
    menor = menor + b;
    if (c < a && c < b && c < d && c < e && c < f && c < g && c < h && c < i && c < j)
    menor = menor + c;
    if (d < a && d < b && d < c && d < e && d < f && d < g && d < h && d < i && d < j)
    menor = menor + d;
    if (e < a && e < b && e < c && e < d && e < f && e < g && e < h && e < i && e < j)
    menor = menor + e;
    if (f < a && f < b && f < c && f < d && f < e && f < g && f < h && f < i && f < j)
    menor = menor + f;
    if (g < a && g < b && g < c && g < d && g < e && g < f && g < h && g < i && g < j)
    menor = menor + g;
    if (h < a && h < b && h < c && h < d && h < e && h < f && h < g && h < i && h < j)
    menor = menor + h;
    if (i < a && i < b && i < c && i < d && i < e && i < f && i < g && i < h && i < j)
    menor = menor + i;
    if (j < a && j < b && j < c && j < d && j < e && j < f && j < g && j < h && j < i)
    menor = menor + j;

    Console.WriteLine($"O maior é {maior} e o menor é {menor}");
