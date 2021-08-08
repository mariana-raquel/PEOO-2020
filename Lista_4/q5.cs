using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe o dia da semana");
    string dia = Console.ReadLine();
    Console.WriteLine("Informe a hora inicial do filme");
    int hora = int.Parse(Console.ReadLine());
    int preço = 0;

    if (dia == "Segunda" || dia == "Terça" || dia == "Quarta")
    preço = 10 - 2;

    if (dia == "Sexta" || dia == "Sábado")
    preço = 10 + 5;

    if (hora < 17)
    preço = preço - 2;

    Console.WriteLine($"O valor da entrada é R$ {preço:0.00}");
  }
}
