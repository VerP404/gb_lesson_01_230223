// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());

int remains = Remains(number1, number2);

if (remains == 0)
{
    Console.WriteLine($"Первое число {number1} кратно {number2}");
}
else
{
    Console.WriteLine($"Остаток от деления первого числа {number1} от второго числа {number2} -> {remains}");
}

int Remains(int num1, int num2)
{
    return num1 % num2;
}