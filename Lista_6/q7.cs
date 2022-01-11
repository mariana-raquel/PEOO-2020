using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string f = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine(f);
    int e = f.IndexOf(' ');
    while (e != -1)
    {
      Console.WriteLine(f.Substring(e+1));
      f = f.Substring(e + 1);
      e = f.IndexOf(' ');
    }
    Console.ReadKey();
  }
}
