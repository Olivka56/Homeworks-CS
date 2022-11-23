// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
int sum = SumOddPoz(array);

Console.WriteLine($"Всего {size} чисел, сумма элементов на нечетных позициях равна {sum}");

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }

    return numbers;
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

int SumOddPoz(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum = sum + numbers[i];
    }

    return sum;
}