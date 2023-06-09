﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
String input = Console.ReadLine();
int date = Convert.ToInt32(input);
if (date <= 7)                                    // в недели 7 календарных дней
{
    if (date == 1)                                // определяем день недели (Понедельник)
    {
        Console.WriteLine("Сегодня понедельник");
    }
    else if (date == 2)                           // определяем день недели (Вторник)
    {
        Console.WriteLine("Сегодня вторник");
    }
    else if (date == 3)                          // определяем день недели (Среда)
    {
        Console.WriteLine("Сегодня среда");
    }
    else if (date == 4)                         // определяем день недели (Четверг)
    {
        Console.WriteLine("Сегодня четверг");
    }
    else if (date == 5)                         // определяем день недели (Пятница)
    {
        Console.WriteLine("Сегодня пятница");
    }
    else if (date == 6)                         // определяем день недели (Суббота)
    {
        Console.WriteLine("Сегодня суббота, выходной день!!");
    }
    else if (date == 7)                         // определяем день недели (Воскресенье)
    {
        Console.WriteLine("Сегодня воскресенье, выходной день!!");
    }
}
else
Console.WriteLine("Столько дней в недели не бывает!!"); // если количество дней больше чем дней в неделе