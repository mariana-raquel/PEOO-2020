using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine();
    int e = a.IndexOf(' ');
    string b;
    while (e != -1)
    {
      b = a.Substring(0,e);
      Console.Write(b.Length);
      a = a.Substring(e + 1);
      e = a.IndexOf(' ');
    }
    Console.Write(a.Length);
    Console.WriteLine();
  }
}
