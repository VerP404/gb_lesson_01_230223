// на вход 3 числа
// на выход максимальное из них
Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"Число {max} максимальное из чисел: {a}, {b}, {c}");
