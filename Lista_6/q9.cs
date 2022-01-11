using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string f = Console.ReadLine();
    Console.WriteLine();
    int i = 1;
    while (i <= f.Length)
    {
      Console.WriteLine($"{i} - {f}");
      i++;
    }
    Console.ReadKey();
  }
}
