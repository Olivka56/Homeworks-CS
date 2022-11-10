/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int n = number;
int rev = 0;
while (n > 0)
{
    int lastDigit = n % 10;
    n /= 10;
    rev = rev * 10 + lastDigit;
}

Console.WriteLine(number == rev ? "Yes" : "No");

