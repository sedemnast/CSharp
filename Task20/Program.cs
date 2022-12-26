using static System.Console;
Clear();

WriteLine("Введите координаты точки A");
Write("Введите ax: ");
int ax = int.Parse(ReadLine()!);
Write("Введите ay: ");
int ay = int.Parse(ReadLine()!);

WriteLine("Введите координаты точки B");
Write("Введите bx: ");
int bx = int.Parse(ReadLine()!);
Write("Введите by: ");
int by = int.Parse(ReadLine()!);

double length = Math.Sqrt(Math.Pow((bx-ax),2)+ Math.Pow((by-ay),2));
WriteLine($"{length:f2}");

