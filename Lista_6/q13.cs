using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine();
    int k = a.Length - 1;
    while (k > 0)
    {
      Console.Write(a[k]);
      k--;
    }
    Console.WriteLine(a[k]);
  }
}
