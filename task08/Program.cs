// на вход число N
// на выход все чётные числа от 1 до N
Console.Write("Введите целое число N: ");
try
{
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 2)
    {
        Console.Write($"Четные числа от 1 до {N}: 2");
        for (int i = 4; i <= N; i = i + 2)
        {
            Console.Write(", " + i);
        }
    }
    else if (N == 2)
    {
        Console.Write($"Четные числа от 1 до {N}: 2");
    }
    else
    {
        Console.Write("Введите число больше 1");
    }
}
catch
{
    Console.Write("Вы ввели не целое число");
}
