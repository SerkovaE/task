// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = GetIntInput();
int[] Array = new int[5];
FillArray(Array);

if (Fivenumber(number))
{
    if (Array[0]==Array[5-1] && Array[1]==Array[5-2])
    {
        Console.WriteLine($"Число '{number}' является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число '{number}' не является палиндромом.");
    }
}




void FillArray(int[] collection)
{
    int length = collection.Length;
    int number1 = number;
    for (int i = 1; i <= length; i++)
    {
        collection[length - i] = number1 % 10;
        number1 /= 10;
    }

}

bool Fivenumber(int number)
{
    if (9999 < number && number < 100000)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число.");
        return false;
    }
}

int GetIntInput()
{
    int result = int.Parse(Console.ReadLine()!);
    return result;
}