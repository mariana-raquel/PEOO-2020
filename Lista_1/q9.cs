Console.WriteLine("Informe sua massa em kg:");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("Informe sua altura em metros:");
double altura = double.Parse(Console.ReadLine());

double IMC = peso / (altura*altura);
Console.WriteLine($"Seu IMC é {IMC}");
