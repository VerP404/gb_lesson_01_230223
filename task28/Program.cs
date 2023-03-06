// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine(Factorial(number));
}
else
{
    Console.WriteLine("Введено некорректное число");
}

int Factorial(int num)
{
    int multiply  = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multiply  = multiply  * i;
        }
    }
    return multiply ;
}



