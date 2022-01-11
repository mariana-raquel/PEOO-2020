using System;

  class MainClass {
    public static double Diagonal(double b, double h) {
      return Math.Sqrt(b * b + h * h);
    }
    static void Main(string[] args) {
      Console.WriteLine("Digite a bse e altura:");
      string[] valores = Console.ReadLine().Split(' ');
      double a = double.Parse(valores[0]);
      double c = double.Parse(valores[1]);
      double d = Diagonal(a, c);
      Console.WriteLine(d);
  }
}
