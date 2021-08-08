using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o número do mês");
    int mes = int.Parse(Console.ReadLine());
    if (mes == 1)
    Console.WriteLine($"O mês de janeiro é do primeiro trimestre do ano");
    if (mes == 2)
    Console.WriteLine($"O mês de fevereiro é do primeiro trimestre do ano");
    if (mes == 3)
    Console.WriteLine($"O mês de março é do primeiro trimestre do ano");
    if (mes == 4)
    Console.WriteLine($"O mês de abril é do segundo trimestre do ano");
    if (mes == 5)
    Console.WriteLine($"O mês de maio é do segundo trimestre do ano");
    if (mes == 6)
    Console.WriteLine($"O mês de junho é do segundo trimestre do ano");
    if (mes == 7)
    Console.WriteLine($"O mês de julho é do terceiro trimestre do ano");
    if (mes == 8)
    Console.WriteLine($"O mês de agosto é do terceiro trimestre do ano");
    if (mes == 9)
    Console.WriteLine($"O mês de setembro é do terceiro trimestre do ano");
    if (mes == 10)
    Console.WriteLine($"O mês de outubro é do quarto trimestre do ano");
    if (mes == 11)
    Console.WriteLine($"O mês de novembro é do quarto trimestre do ano");
    if (mes == 12)
    Console.WriteLine($"O mês de dezembro é do quarto trimestre do ano");
  }
}
