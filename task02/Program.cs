// на вход 2 числа
// на выход какое число большее, а какое меньшее
Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine($"Число {a} равно числу {b}");
}
else if(a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}");
}    