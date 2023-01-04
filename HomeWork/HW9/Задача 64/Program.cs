﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Numbers (int N)
{
    if (N==1) return N;
    else
    Console.Write($"{Numbers(N-1)}, ");
    return N;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим координаты чисел
int N = EnterData("Введите число N: ");
// Поиск и вывод чисел 
Numbers(N);
Console.WriteLine(N);