// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableWhile(number);
TableFor(number);


void TableWhile(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i, 4}  {i*i, 4}");
        i++;
    }
}

void TableFor(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}  {i*i}");
    }
}
