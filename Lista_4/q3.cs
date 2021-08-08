using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe o salário atual:");
    double salario = double.Parse(Console.ReadLine());
    double novo = 0;

    if (salario < 500)
    {
      novo = novo + (salario + (salario * 0.20));
      Console.WriteLine($"Seu novo salário é {novo:0.00}");
    }
    if (salario >= 500 && salario <= 1000)
    {
      novo = novo + (salario + (salario * 0.15));
      Console.WriteLine($"Seu novo salário é {novo:0.00}");
    }
    if (salario > 1000)
    {
      novo = novo + (salario + (salario * 0.10));
      Console.WriteLine($"Seu novo salário é {novo:0.00}");
    }
  }
}
