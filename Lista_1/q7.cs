using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um valor monetário:");
    string valor = Console.ReadLine();
    int indVirg = valor.IndexOf(",");
    string resto = valor.Substring(indVirg);
    string centavos = resto.Substring(1);
    int quant = valor.Length;
    int max = quant-3;
    string reais = valor.Substring(0, max);
    Console.WriteLine($"{reais} reais e {centavos} centavos.");
  }
}
