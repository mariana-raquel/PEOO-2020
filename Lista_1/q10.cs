using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Há quantos anos você fuma?");
    double anos = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantos cigarros por dia?");
    double cigarros = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual é o preço da carteira de cigarros?");
    double preço = double.Parse(Console.ReadLine());
    double gasto = (365 * anos)/(20/cigarros)*preço;
    Console.WriteLine($"Total gasto = R$ {gasto}");
  }
}
