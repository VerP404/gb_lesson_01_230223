//Задайте одномерный массив заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumOddElement(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count = count + arr[i];
    }
    return count;
}



Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(number, -100, 100);
PrintArrayInt(array);
int sumOddElement = SumOddElement(array);
Console.WriteLine($" -> {sumOddElement}");