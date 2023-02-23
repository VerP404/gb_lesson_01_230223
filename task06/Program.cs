// на вход число
// на выход является ли оно четное


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0) 
{
    Console.Write($"Число {N} четное");
}
else
{
    Console.Write($"Число {N} не четное");
}