﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"количество цифр -> {ColDigit(number)}");

int ColDigit(int num)
{
    int sum = 0;
    while(num > 0)
    {
        num = num/10;
        sum ++;
    }
    return sum;
}
