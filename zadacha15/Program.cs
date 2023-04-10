// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели");
int weekday = GetIntInput();

int GetIntInput()
{
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ItWeekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    else
    {
        return false;
    };
}

if (weekday > 0 && weekday <= 7)
{
    if (ItWeekend(weekday))
    {
        Console.WriteLine("Сегодня выходной!");
    }
    else
    {
        Console.WriteLine("Сегодня рабочий день.");
    };
}
else
{
    Console.WriteLine("Это не день недели.");
};







