using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string[] horario1 = Console.ReadLine().Split(':');
    int h1 = int.Parse(horario1[0]);
    int m1 = int.Parse(horario1[1]);
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string[] horario2 = Console.ReadLine().Split(':');
    int h2 = int.Parse(horario2[0]);
    int m2 = int.Parse(horario2[1]);
    int horas = h1 + h2;
    int minutos = m1 + m2;
    if (minutos > 60)
    {
    minutos = minutos - 60;
    horas = horas + 1;
    }
    Console.WriteLine($"Total de horas = {horas:00}:{minutos}");
  }
}
