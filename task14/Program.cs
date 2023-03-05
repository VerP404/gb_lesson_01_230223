// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 21;

bool remains = Remains(number, number1, number2);
Console.WriteLine(remains ? "Да" : "нет");

bool Remains(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}