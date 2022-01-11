using System;

  class MainClass {
    public static double VolumeEsfera(double r) {
      return (4 * Math.PI * (r * r * r))/3;
    }
    static void Main(string[] args) {
      Console.WriteLine("Informe o raio:");
      double a = double.Parse(Console.ReadLine());
      double volume = VolumeEsfera(a);
      Console.WriteLine(volume);
  }
}
