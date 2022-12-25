using static System.Console;

WriteLine("Введите трехзначное число:");
int n = Convert.ToInt32(ReadLine());

WriteLine(n >= 100 && n <= 999?$"{n/10%10}":"Вы ввели не трехзначное число");