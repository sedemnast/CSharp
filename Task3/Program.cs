using static System.Console;

WriteLine("Введите число от 1 до 7:");
int a = int.Parse(ReadLine()!);

if(a == 1) {
    WriteLine("Понедельник");
}
    else if (a == 2) {
    WriteLine("Вторник");
    }
        else if (a == 3) {
        WriteLine("Среда");
        }
            else if (a == 4) {
            WriteLine("Четверг");
            }
                else if (a == 5) {
                WriteLine("Пятница");
                }
                    else if (a == 6) {
                    WriteLine("Суббота");
                    }
                        else if (a == 7) {
                        WriteLine("Воскресенье");
                        }
else
{
    WriteLine("Введено неверное число");
}
