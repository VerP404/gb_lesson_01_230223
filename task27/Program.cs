// Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountDigit(number));
int CountDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        count = count + num % 10;
        num = num/10;
    }
    return count;
}