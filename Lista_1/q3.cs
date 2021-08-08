Console.WriteLine("Digite o raio de um círculo:");
double raio = double.Parse(Console.ReadLine());
double circ = 3.14 * 2 * raio;
double area = 3.14 * (raio*raio);

Console.WriteLine($"Circunferência = {circ}");
Console.WriteLine($"Área = {area:0.00}");
