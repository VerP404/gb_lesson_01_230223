// Задача 38. задайте массив вещественных чисел
// Найдите разницу между макс и мин элементами

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }

    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    double maxMin = Math.Round((max - min), 1);
    Console.WriteLine($"Разница между максимальным элементом массива {max} и минимальным {min} равна: {maxMin}");

}

double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(array);
DifferenceMaxMin(array);