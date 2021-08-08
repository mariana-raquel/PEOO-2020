using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite três valores:");
    int pri = int.Parse(Console.ReadLine());
    int seg = int.Parse(Console.ReadLine());
    int ter = int.Parse(Console.ReadLine());
    int a = 0;
    int b = 0;
    int c = 0;

    if (pri > seg && pri > ter)
    {
    a = a + pri;
    b = b + seg;
    c = c + ter;
    }
    if (seg > pri && seg > ter)
    {
    a = a + seg;
    b = b + pri;
    c = c + ter;
    }
    if (ter >pri && ter > seg)
    {
    a = a + ter;
    b = b + pri;
    c = c + seg;
    }
    
    if (a >= b + c)
    Console.WriteLine("Esses valores não formam um triângulo");
    if (a * a == b * b + c * c)
    Console.WriteLine("Esses valores formam um triângulo retângulo");
    if (a == b && a == c && b == c)
    Console.WriteLine("Esses valores formam um triângulo equilatero");
    if (a == b || a == c || b == c)
    Console.WriteLine("Esses valores formam um triângulo isósceles");
  }
}
