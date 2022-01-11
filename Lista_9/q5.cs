using System;

  class MainClass {
    public static double VolumeLitros(double h, double l, double p) {
      return h * l * p;
    }
    static void Main(string[] args) {
      Console.WriteLine("Digite a altura, largura e a profundidade:");
      string[] valores = Console.ReadLine().Split(' ');
      double a = double.Parse(valores[0]);
      double b = double.Parse(valores[1]);
      double c = double.Parse(valores[2]);
      double volume = VolumeLitros(a, b, c);
      Console.WriteLine(volume);
  }
}
