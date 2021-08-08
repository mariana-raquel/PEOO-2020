using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite sua data de nascimento:");
    string nasc = Console.ReadLine();
    string ano = nasc.Substring(6,4);
    int anoNasc = int.Parse(ano);
    int idade = 2020 - anoNasc;
    Console.WriteLine($"Você terá {idade} anos!");
  }
}
