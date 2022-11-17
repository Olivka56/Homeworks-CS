// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
int evens = CountEvens(array);

Console.WriteLine($"Из {size} чисел {evens} четные");


int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }

    return numbers;
}

int CountEvens(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}