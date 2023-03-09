// // Задача 32: Напишите программу замена элементов
// // массива: положительные элементы замените на
// // соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreateArrayFilling(int size, int min, int max)
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

int[] InvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (arr[i] * -1);        
    }
    return arr;
}


int[] array = CreateArrayFilling(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int[] invertArray = InvertArray(array);
PrintArray(invertArray);














// int[] CreateArrayFilling(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }



// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0 ) sum += arr[i];
//     }
//     return sum;
// }

// int GetSumNegativeElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < 0 ) sum += arr[i];
//     }
//     return sum;
// }


// int array = CreateArrayFilling(12, -9, 9);
// PrintArray(array);

// int getSumNegativeElem = GetSumNegativeElem(array);
// Console.WriteLine(getSumNegativeElem);
// int getSumPositiveElem = GetSumPositiveElem(array);
// Console.WriteLine(getSumPositiveElem);

