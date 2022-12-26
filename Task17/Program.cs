using static System.Console;
Clear();

Write("Введите номер четверти: ");
bool isParse=int.TryParse(ReadLine(),out int i);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}

switch(i)
{
    case 1:
    {
        WriteLine("x > 0 y > 0");
        break;
    }
    case 2:
    {
        WriteLine("x < 0 y > 0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0 y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0 y < 0");
        break;
    }
    default:
    {
        WriteLine("Нет такой четверти");
        break;
    }
}

// if(i < 1 || i > 4)
// {
//     WriteLine("Ошибка");
//     return;
// }
// if (i == 1)
// {
//     WriteLine("x > 0 y > 0");
// }
// if (i == 2)
// {
//     WriteLine("x < 0 y > 0");
// }
// if (i == 3)
// {
//     WriteLine("x < 0 y < 0");
// }
// if (i == 4)
// {
//     WriteLine("x > 0 y < 0");
// }