﻿// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine ());
Task23 (number);

void Task23 (int value)
{
    Console.WriteLine ($"Таблица кубов чисел от 1 до {value}");
    for (int i = 1; i<=value; i++)
    {
        Console.Write ($"{Math.Pow(i, 3)} ");
    }
    Console.WriteLine ();
}