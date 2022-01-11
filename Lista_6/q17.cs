using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase:");
    string a = Console.ReadLine();
    int e = a.IndexOf(' ');
    string b;
    int s = 0;
    int x = 0;
    while (e != -1)
    {
      b = a.Substring(0, e+1);
      while (x < b.Length)
        {
          if (a[x] == 'A' || a[x] == 'E' || a[x] == 'I'||
          a[x] == 'O' || a[x] == 'U' ||
          a[x] == 'a' || a[x] == 'e' ||
          a[x] == 'i' || a[x] == 'o' || a[x] == 'u') 
            s = s + 1;
          if (b[x] == ' ')
          {
            while (s > 0)
            {
              Console.Write($"{b}");
              s--;
            }
          }
        x++;
        }
        a = a.Substring(e+1);
        x = 0;
        s = 0;
        e = a.IndexOf(' ');
    }
    while (x < a.Length)
      {
        if (a[x] == 'A' || a[x] == 'E' || a[x] == 'I'||
        a[x] == 'O' || a[x] == 'U' || 
        a[x] == 'a' || a[x] == 'e' ||
        a[x] == 'i' || a[x] == 'o' || a[x] == 'u')          
        s = s + 1;
        if (a[x] == a[a.Length-1])
        {
          while (s > 0)
          {
            Console.Write($"{a} ");
            s--;              
          }
        }
      x++;
    }
  Console.WriteLine();
  }
}
