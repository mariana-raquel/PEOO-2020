using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa:");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);
    Console.WriteLine($"A data é {dia} de {mes:00} de 2013{ano}");
  }
}
