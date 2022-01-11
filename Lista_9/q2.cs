using System;

  class MainClass {
    public static double AreaCirculo(double raio) {
      return Math.PI * raio * raio;
    }
    static void Main(string[] args) {
      Console.WriteLine("Digite o raio");
      double a = double.Parse(Console.ReadLine());
      double area = AreaCirculo(a);
      Console.WriteLine(area);
    }
  }
