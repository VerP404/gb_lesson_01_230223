// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Reverse(number));
Console.WriteLine(Palindrom(number, Reverse(number)) ? $"Палиндром" : "Не палиндром");

int Reverse(int num)
{
    int rev = 0;
    while (num > 0)
    {
        int digit = num % 10;
        rev = (rev * 10) + digit;
        num = num / 10; 
    }
    return rev;
}

bool Palindrom(int num, int rev)
{
    return num == rev;
}

