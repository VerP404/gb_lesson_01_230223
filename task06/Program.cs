// на вход число
// на выход является ли оно четное


Console.Write("Введите число N: ");
string N = Console.ReadLine();

if (Int32.TryParse(N, out int x))
{
    if (x % 2 == 0)
    {
        Console.Write($"Число {x} четное");
    }
    else
    {
        Console.Write($"Число {x} не четное");
    }
}
else
{
    Console.Write("Вы ввели не целое число");

}


