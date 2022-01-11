using System;

  class MainClass {
    public static void AntecessorSucessor (int x, out int antecessor, out int sucessor)  {
      antecessor = x - 1;
      sucessor = x + 1;
    }
    static void Main(string[] args) {
      Console.WriteLine("Digite um valor inteiro:");
      int x = int.Parse(Console.ReadLine());
      int a, b;
      AntecessorSucessor(x, out a, out b);
      Console.WriteLine($"O antecessor de {x} é {a}, e seu sucessor é {b}");
  }
}
