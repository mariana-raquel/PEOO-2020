using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string f = Console.ReadLine();
    int e = f.IndexOf(' ');
    Console.WriteLine();
    while (e != -1)
    {
      Console.Write(f[e-1]);
      f = f.Substring(e + 1);
      e = f.IndexOf(' ');
    }
    int t = f.Length;
    Console.Write(f[t-1]);
    Console.ReadKey();
  }
}
