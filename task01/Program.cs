Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b*b == a)
{
    Console.WriteLine($"Число {b} является квадратом числа {a}");
}
else
{
    Console.WriteLine($"Число {b} не является квадратом числа {a}");  
}    