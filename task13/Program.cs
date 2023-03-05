// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"третьей цифра -> {TreeDigit(number)}");

}

int TreeDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

