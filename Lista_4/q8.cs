using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um horário");
    string[] h1 = Console.ReadLine().Split(':');
    int hora = int.Parse(h1[0]);
    int minuto = int.Parse(h1[1]);
    if (hora >= 00 && hora < 24 && minuto >= 00 && minuto < 60)
    Console.WriteLine("A hora informada é válida");
    else 
    Console.WriteLine("A hora informada não é válida");
  }
}
