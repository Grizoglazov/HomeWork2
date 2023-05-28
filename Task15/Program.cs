// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
String input = Console.ReadLine();
int date = Convert.ToInt32(input);
if (date <= 7)
{
    if (date == 1)
    {
        Console.WriteLine("Сегодня понедельник");
    }
    else if (date == 2)
    {
        Console.WriteLine("Сегодня вторник");
    }
    else if (date == 3)
    {
        Console.WriteLine("Сегодня среда");
    }
    else if (date == 4)
    {
        Console.WriteLine("Сегодня четверг");
    }
    else if (date == 5)
    {
        Console.WriteLine("Сегодня пятница");
    }
    else if (date == 6)
    {
        Console.WriteLine("Сегодня суббота, выходной день!!");
    }
    else if (date == 7)
    {
        Console.WriteLine("Сегодня воскресенье, выходной день!!");
    }
}
else
Console.WriteLine("Столько дней в недели не бывает!!"); 