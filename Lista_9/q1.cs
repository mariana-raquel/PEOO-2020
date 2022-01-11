using System;

  class MainClass {
    public static double Maior(double x, double y) {
      return Math.Max(x, y);
    }
    static void Main(string[] args) {
      Console.WriteLine("Digite dois números:");
      string[] valores = Console.ReadLine().Split(' ');
      double a = double.Parse(valores[0]);
      double b = double.Parse(valores[1]);
      double maior = Maior(a, b);
      Console.WriteLine(maior);
    }
  }
