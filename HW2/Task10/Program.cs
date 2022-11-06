Console.Write("Напишите трехзначное число: ");
string number = Console.ReadLine();
int n = int.Parse(number);

int middleDigit = n / 10 % 10;

Console.WriteLine(middleDigit);