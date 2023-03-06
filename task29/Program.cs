// Задача 29: Напишите программу, которая
// задает массив из 8 элементов, заполненный 
// псевдослучайными числами и выводит их на экран
int[] array = new int[8];

ArrayFilling(array);
ArrayPrint(array);


void ArrayFilling(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
}

void ArrayPrint(int[] arr)
{
    Console.Write("[");
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write(arr[i] + "]");
        }
        else
        {
            Console.Write(arr[i] + ", ");

        }
    }
}
