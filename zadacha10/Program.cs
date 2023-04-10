// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number;
Console.WriteLine("Введите трехзначное число");
number = Convert.ToInt32(Console.ReadLine());


if (ThreeDigitNumber(number))
{
    Console.WriteLine($"Введенное число '{number}'.");
    int secondNumber=number/10%10;
    Console.WriteLine($"Вторая цифра '{secondNumber}'.");
}
else
{
   Console.WriteLine("Вы ввели не трехзначное число."); 
}




bool ThreeDigitNumber(int number)
{
    if (99 < number && number < 1000)
    {
        return true;
    }
    else
    {
        return false;        
    }
}



