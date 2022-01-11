using System;

  class MainClass {
    public static double Frete(double massa, double distancia) {
    return 0.01 * massa * distancia;
    }
    static void Main(string[] args) {
      Console.WriteLine("Digite a massa e a distância:");
      string[] valores = Console.ReadLine().Split(' ');
      double a = double.Parse(valores[0]);
      double b = double.Parse(valores[1]);
      double preço = Frete(a, b);
      Console.WriteLine(preço);
  }
}
