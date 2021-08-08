using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite seu nome:");
    string[] nc = Console.ReadLine().Split(' ');
    string n1 = nc[0];
    string n2 = nc[1];
    Console.WriteLine($"{n2}, {n1}");
  }
}
