﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Решение через через "if".
Console.WriteLine("Укажите число, обозначающая день недели:");
Console.WriteLine("1 - понедельник, 2 - вторник, 3 - среда, 4 - четверг,");
Console.WriteLine("5 - пятница, 6 - суббота, 7 - воскресенье. (Памятка для пользователя)");
Console.WriteLine(" ");
Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Да, выходной!");
}
if (day >=1 && day <=5)
{
    Console.WriteLine("Нет, будний день!");
}
if (day <=0 || day >= 8)
{
    Console.WriteLine("Неверно введено число!");
}