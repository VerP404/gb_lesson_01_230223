// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int col_digit = 3;


Console.WriteLine(ColDigit(number, col_digit) ? SecondDigit(number) : "вы ввели не трехзначное число");


bool ColDigit(int num, int col)
{
    int sum = 0;
    while (num > 0)
    {
        sum++;
        num = num / 10;
    }
    return sum == col;
}

int SecondDigit(int num)
{
    return (num / 10) % 10;
}
