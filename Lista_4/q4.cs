O que outras pessoas estão dizendo
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe o nome da primeira pessoa");
    string n1 = Console.ReadLine();
    Console.WriteLine("Informe a data de nascimento");
    string[] data1 = Console.ReadLine().Split('/');
    int d1 = int.Parse(data1[0]);
    int m1 = int.Parse(data1[1]);
    int a1 = int.Parse(data1[2]);
    Console.WriteLine("Informe o nome da segunda pessoa");
    string n2 = Console.ReadLine();
    Console.WriteLine("Informe a data de nascimento");
    string[] data2 = Console.ReadLine().Split('/'); 
    int d2 = int.Parse(data2[0]);
    int m2 = int.Parse(data2[1]);
    int a2 = int.Parse(data2[2]);

    if (a1 < a2 || m1 < m2 && a1 == a2 || d1 < d2 && m1 == m2 && a1 == a2)
    Console.WriteLine($"{n1} é mais velho(a) que {n2}");

    if (a1 > a2 || m1 > m2 && a1 == a2 || d1 > d2 && m1 == m2 && a1 == a2)
    Console.WriteLine($"{n2} é mais velho(a) que {n1}");

    if (d1 == d2 && m1 == m2 && a1 == a2)
    Console.WriteLine($"{n1} e {n2} possuem a mesma idade");
  }
}
