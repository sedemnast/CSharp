using static System.Console;

WriteLine("Является ли число кратным 7 и 23?");
WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());

WriteLine(a%7 == 0 && a%23 == 0?"Да":"Нет");