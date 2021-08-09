int x = 102;
int r;
string s = "";
while (x > 0)
{
  r = x % 2;
  x = x / 2;
  s = r + s;
}
Console.WriteLine(s);
Console.ReadKey(); 
102 / 2 = 51 resto 0
51 / 2 = 25 resto 1
25 / 2 = 12 resto 1
12 / 2 = 6 resto 0
6 / 2 = 3 resto 0
3 / 2 = 1 resto 1
1 / 2 = 0 resto 1
0 / 2 = 0 resto 0

1100110
