// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{

    Console.WriteLine("Вы ввели не натуральное число!");
}
else
{
    Console.WriteLine(Exponentiation(numberA, numberB));
}

int Exponentiation(int numA, int numB)
{
    int count = 0;
    int exponent = 1;
    while (count < numB)
    {
        exponent = exponent * numA;
        count++;
    }
    return exponent;
}





