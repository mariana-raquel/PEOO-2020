Console.WriteLine("Digite a base e a altura do retângulo:");
double bas = double.Parse(Console.ReadLine());
double alt = double.Parse(Console.ReadLine());

double area = bas * alt;
double perimetro = bas * 2 + alt * 2;
double diagonal = Math.Sqrt((bas*bas)+(alt*alt));

Console.Write($"Área = {area}");
Console.Write(" - ");
Console.Write($"Perímetro = {perimetro}");
Console.Write(" - ");
Console.Write($"Diagonal = {diagonal}");
