// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

double[] array = CreateArray(size);
PrintArray(array);

double max = GetMax(array);
double min = GetMin(array);

Console.WriteLine($"Разница между максимальным - {max} и минимальным - {min} элементом равна {max - min}");

double[] CreateArray(int size)
{
    double[] numbers = new double[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().NextDouble() * 1000;
    }

    return numbers;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}