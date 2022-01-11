using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma sequência de números separados por vírgula:");
    string a = Console.ReadLine();
    int v = a.IndexOf(',');
    int s = 0;

    while (v != -1)
    {
      s += int.Parse(a.Substring(0,v));
      a = a.Substring(v+1);
      v = a.IndexOf(',');
    }
    s += int.Parse(a);
    Console.WriteLine($"Soma = {s}");
  }
}
