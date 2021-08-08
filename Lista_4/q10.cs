using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe o valor unitário do produto");
    double valor = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade comprada");
    double quant = double.Parse(Console.ReadLine());
    double preço1 = 0;
    double preço2 = 0;
    double preço3 = 0;

    if (quant <= 10)
    {
      preço1 += ((quant * valor) * 0.95);
      Console.WriteLine($"O total a ser pago é R$ {preço1:0.00}");
    }
    
    if (quant > 10 && quant <= 50)
    { 
      preço2 += (quant - 10) * valor * 0.90 + 10 * valor * 0.95;
      Console.WriteLine($"O total a ser pago é R$ {preço2:0.00}");
    }
    
    if (quant > 50)
    {
      preço3 += (quant - 50) * valor * 0.80 + (40 * valor) * 0.90 + 10 * valor * 0.95;
      Console.WriteLine($"O total a ser pago é R$ {preço3:0.00}");
    }
  }
}
