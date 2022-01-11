using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string f = Console.ReadLine();
    Console.WriteLine();
    int i = 1;
    int t = f.Length;
    while (i <= t)
    {
    Console.Write(f.Substring(i));
    Console.WriteLine(f.Substring(0,i));
    i++;
    } 
    Console.ReadKey();
  }
}
