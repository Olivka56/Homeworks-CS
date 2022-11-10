/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Коорднаты A: ");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());
double za = double.Parse(Console.ReadLine());
Console.Write("Коорднаты В: ");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());
double zb = double.Parse(Console.ReadLine());

double ab = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));

Console.WriteLine(Math.Round(ab, 2));



