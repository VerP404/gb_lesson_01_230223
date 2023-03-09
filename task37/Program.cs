// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}



int[] CountDigit(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size +=1;
    int[] array2 = new int [size];

    for (int i = 0; i < size; i++)
    {
        int p = arr.Length -1;
        array2[i] = arr[i]*arr[p - i];
    }
    if (arr.Length % 2 != 0) array2[size-1] = arr[arr.Length/2];
    return array2;

}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(number, 0, 10);
PrintArray(array);

PrintArray(CountDigit(array));