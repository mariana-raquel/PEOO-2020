using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um valor monetário inteiro:");
    int valor = int.Parse(Console.ReadLine());
    int cem = valor / 100;
    int cinquenta = valor % 100 / 50;
    int vinte = valor % 100 % 50 / 20;
    int dez = valor % 100 % 50 % 20 / 10;
    int cinco = valor % 100 % 50 % 20 % 10 / 5;
    int dois = valor % 100 % 50 % 20 % 10 % 5 / 2;
    int um = valor % 100 % 50 % 20 % 10 % 5 % 2 / 1;

    Console.WriteLine($"{cem} cédula(s) de 100 reais");
    Console.WriteLine($"{cinquenta} cédula(s) de 50 reais");
    Console.WriteLine($"{vinte} cédula(s) de 20 reais");
    Console.WriteLine($"{dez} cédula(s) de 10 reais");
    Console.WriteLine($"{cinco} cédula(s) de 5 reais");
    Console.WriteLine($"{dois} cédula(s) de 2 reais");
    Console.WriteLine($"{um} moeda(s) de 1 real");
  }
}
