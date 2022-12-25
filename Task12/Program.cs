using static System.Console;

WriteLine("Является ли второе число кратным первому?");
WriteLine("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
//int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());
//int b = int.Parse(ReadLine()!);

WriteLine(a%b == 0?$"Число {a} кратно числу {b}":$"Число {a} не кратно числу {b}, остаток {a%b}");

// if(a%b == 0)
// {
//     WriteLine($"Число {a} кратно числу {b}");
// }
// else
// {
//     WriteLine($"Число {a} не кратно числу {b}");
//     Write($"Остаток {a%b}");
// }