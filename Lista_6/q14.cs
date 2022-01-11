using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine();
    int e = a.IndexOf(' ');
    string b;
    int bk;
    while (e != -1)
    {
      b = a.Substring(0,e);
      bk = b.Length-1;
      while (bk >= 0)
      {
        Console.Write(b[bk]);
        bk--;
      }
      Console.WriteLine();
      a = a.Substring(e + 1);
      e = a.IndexOf(' ');
    }
    bk = a.Length-1;
    while (bk >= 0)
      {
        Console.Write(a[bk]);
        bk--;
      }
      Console.WriteLine();
  }
}
