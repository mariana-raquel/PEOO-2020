using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string inicio = Console.ReadLine();
    string[] entrada = inicio.Split('+', '-', '*', '/');
    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]);
    if (inicio.Contains('+') == true)
    Console.WriteLine($"O resultado da operação é {a+b}");
    if (inicio.Contains('-') == true)
    Console.WriteLine($"O resultado da operação é {a-b}");
    if (inicio.Contains('*') == true)
    Console.WriteLine($"O resultado da operação é {a*b}");
    if (inicio.Contains('/') == true)
    Console.WriteLine($"O resultado da operação é {a/b}");
  }
}
