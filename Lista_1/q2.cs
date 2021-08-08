Console.WriteLine("Digite as notas dos dois bimestres da disciplina:");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int b1 = n1 * 2;
int b2 = n2 * 3;
int media = (b1 + b2)/5;
Console.WriteLine($"Média Parcial = {media}");
