// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
if (number >=10000)
{
    number%=1000;
    Console.WriteLine("$ Третья цифра: {0}", number/=100);
}
else if (number >=1000)
{
    number%=100;
    Console.WriteLine("$ Третья цифра: {0}", number/=10);
}
else if (number >=100)
{
    Console.WriteLine("$ Третья цифра: {0}", number%=10);
}
else
Console.WriteLine("Третьей цифры нет");