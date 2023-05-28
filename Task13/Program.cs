﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
string input = Console.ReadLine();                              // присваиваю переменной input полученный аргумент
int number = Convert.ToInt32(input);                            // ковертирую в целое значение переменной input
if (number >=10000 && number <=99999)                           // выделяю диапазон для переменной 
{
    number%=1000;                                               // уменьшаю разрядность числа
    Console.WriteLine("Третья цифра: {0}", number/=100);        // нахожу искомое число по условию задачи
}
else if (number >=1000 && number <=9999)                        // выделяю диапазон для переменной 
{
    number%=100;                                                // уменьшаю разрядность числа
    Console.WriteLine("Третья цифра: {0}", number/=10);         // нахожу искомое число по условию задачи
}
else if (number >=100 && number <=999)                           // выделяю диапазон для переменной 
{
    Console.WriteLine("Третья цифра: {0}", number%=10);          // нахожу искомое число по условию задачи
}
else
Console.WriteLine("Третьей цифры нет");                          // если число состоит из 2-х чисел