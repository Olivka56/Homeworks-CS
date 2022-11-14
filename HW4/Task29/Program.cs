// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

void ReadArray(int length, int[] array)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int length, int[] array)
{
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[length - 1]}");
    Console.Write("]");
}

Console.Write("Введите длину массива: ");
int m = int.Parse(Console.ReadLine());

int[] arr = new int[m];
ReadArray(m, arr);
PrintArray(m, arr);
