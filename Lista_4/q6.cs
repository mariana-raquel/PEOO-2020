using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe o primeiro horário");
    string[] hora1 = Console.ReadLine().Split(':', ' ');
    int h1 = int.Parse(hora1[0]);
    int m1 = int.Parse(hora1[1]);
    string t1 = hora1[2];

    Console.WriteLine("Informe o segundo horário");
    string[] hora2 = Console.ReadLine().Split(':', ' ');
    int h2 = int.Parse(hora2[0]);
    int m2 = int.Parse(hora2[1]);
    string t2 = hora2[2];

    if (t1 == "PM" && t2 == "AM")
    Console.WriteLine($"O maior horário é {h1}:{m1} {t1}");

    if (t1 == "AM" && t2 == "PM")
    Console.WriteLine($"O maior horário é {h2}:{m2} {t2}");

    if (t1 == "AM" && t2 == "AM" && h1 > h2)
    Console.WriteLine($"O maior horário é {h1}:{m1} {t1}");

    if (t1 == "AM" && t2 == "AM" && h1 < h2)
    Console.WriteLine($"O maior horário é {h2}:{m2} {t2}");

    if (t1 == "AM" && t2 == "AM" && h1 == h2 && m1 > m2)
    Console.WriteLine($"O maior horário é {h1}:{m1} {t1}");

    if (t1 == "AM" && t2 == "AM" && h1 == h2 && m2 > m1)
    Console.WriteLine($"O maior horário é {h2}:{m2} {t2}");

    if (t1 == "PM" && t2 == "PM" && h1 > h2)
    Console.WriteLine($"O maior horário é {h1}:{m1} {t1}");

    if (t1 == "PM" && t2 == "PM" && h1 < h2)
    Console.WriteLine($"O maior horário é {h2}:{m2} {t2}");

    if (t1 == "PM" && t2 == "PM" && h1 == h2 && m1 > m2)
    Console.WriteLine($"O maior horário é {h1}:{m1} {t1}");

    if (t1 == "PM" && t2 == "PM" && h1 == h2 && m2 > m1)
    Console.WriteLine($"O maior horário é {h2}:{m2} {t2}");
  }
}
