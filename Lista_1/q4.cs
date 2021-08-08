Console.WriteLine("Digite as notas dos três bimestres:");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int b1 = n1 * 2;
int b2 = n2 * 2;
int b3 = n3 * 3;

int soma = b1 + b2 + b3;
int falta = (600 - soma)/3;

Console.WriteLine($"Nota pra passar = {falta}");
