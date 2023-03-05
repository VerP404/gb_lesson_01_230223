// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int delSecondDigit = DelSecondDigit(number);

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int threeDigit = num % 10;
    int result = firstDigit * 10 + threeDigit;
    return result;
}

Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
Console.WriteLine($"Итоговое число -> {delSecondDigit}");
