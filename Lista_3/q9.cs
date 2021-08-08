using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o horário no formato hh:mm");
    string[] entrada = Console.ReadLine().Split(':');
    int hora = int.Parse(entrada[0]);
    int minutos = int.Parse(entrada[1]);
    int angulo = 0;
    if (hora > minutos)
    {
    angulo = angulo + ((30 * hora) - (11*minutos) / 2);
    Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");
    }
    if (hora < minutos)
    {
    angulo = angulo + ((11*minutos) / 2 - (30 * hora));
    Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");
    }
  }
}
