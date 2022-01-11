using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine().ToUpper();
    int t = a.Length;
    int va = 0;
    int ve = 0;
    int vi = 0;
    int vo = 0;
    int vu = 0;
    for (int i = 0; i < t; i++)
    {
      if (a[i] == 'A') 
      va += 1;
      if (a[i] == 'E') 
      ve += 1;
      if (a[i] == 'I')
      vi += 1;
      if (a[i] == 'O')
      vo += 1;
      if (a[i] == 'U')
      vu += 1;
    }
    Console.WriteLine($"A – {va}");
    Console.WriteLine($"E – {ve}");
    Console.WriteLine($"I – {vi}");
    Console.WriteLine($"O – {vo}");
    Console.WriteLine($"U – {vu}");
  }
}
