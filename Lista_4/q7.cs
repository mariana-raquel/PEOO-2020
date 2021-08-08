using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a data do aniversário");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);

    if (mes == 1 && dia > 31 || mes == 02 && dia > 29 ||
        mes == 3 && dia > 31 || mes == 04 && dia > 30 ||
        mes == 5 && dia > 31 || mes == 06 && dia > 30 ||
        mes == 7 && dia > 31 || mes == 08 && dia > 31 ||
        mes == 09 && dia > 30|| mes == 10 && dia > 31 ||
        mes == 11 && dia > 30 || mes == 12 && dia > 31 )
    Console.WriteLine("A data informada não é válida.");
    else
    Console.WriteLine("A data informada é válida.");
   
  }
}
