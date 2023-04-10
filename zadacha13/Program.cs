// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int number = GetIntInput();


while (ValidateNumber(number))
{

    Console.WriteLine($"Третья цифра числа  - '{Inthreefigure(number)}'");
    break;
}


bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
        return false;
    }
    else
    {
        return true;
    }
}

int Inthreefigure(int number)
{
    for (int i = 0; i < 2; i++)
    {
        number /= 10;
    }
    return number % 10;
}

int GetIntInput()
{
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

