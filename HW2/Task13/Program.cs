Console.Write("Напишите число: ");
string number = Console.ReadLine();
int n = int.Parse(number);

if (n / 100 != 0)
{
    while (n >= 1000)
    {
        n /= 10;
    }
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
