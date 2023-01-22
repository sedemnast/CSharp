using static System.Console;

Clear();

Write("Введите координаты точки A через пробел: ");
Point A = GetPointFromString(ReadLine()!);
Write("Введите координаты точки B через пробел: ");
Point B = GetPointFromString(ReadLine()!);

double delta = Math.Sqrt(Math.Pow(A.X - B.X, 2)+Math.Pow(A.Y - B.Y, 2)+Math.Pow(A.Z - B.Z, 2));
WriteLine(delta);

Point GetPointFromString(string inStr)
{
    Point res = new Point();
    string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    res.X = int.Parse(par[0]);
    res.Y = int.Parse(par[1]);
    res.Z = int.Parse(par[2]);
    return res;
}

struct Point
{
    public int X;
    public int Y;
    public int Z;
}