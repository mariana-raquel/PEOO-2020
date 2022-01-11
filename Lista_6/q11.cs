using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine();
    int t = a.Length;
    int s = 0;
    for (int i = 0; i < t; i++)
    {
      if (a[i] == '0' || a[i] == '1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5' ||
          a[i] == '6' || a[i] == '7' || a[i] == '8' || a[i] == '9') 
      s  += int.Parse(a[i].ToString());
    }
    Console.WriteLine(s);
  }
}
