using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine();
    int s = 0;
    int e = a.IndexOf(' ');
    while(e != -1)
    {
      a = a.Substring(e+1);
      s += 1;
      e = a.IndexOf(' ');
    }
    s += 1;
    Console.WriteLine(s);
  }
}
