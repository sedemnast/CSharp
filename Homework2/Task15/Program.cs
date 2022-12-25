using static System.Console;
Clear();

WriteLine("Является ли этот день выходным?");
Write("Введите цифру, обозначающую день недели: ");
int day = int.Parse(ReadLine()!);

if(day < 6 & day > 0) 
{
    WriteLine("Нет, это рабочий день");
}
    else if(day >= 6 & day <= 7) 
    {
    WriteLine("Да, это выходной");
    }
else
{
    WriteLine("Такого дня недели не существует");
}