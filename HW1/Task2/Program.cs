Console.Write("a= ");
string a_s = Console.ReadLine();
int a = int.Parse(a_s);

Console.Write("b= ");
string b_s = Console.ReadLine();
int b = int.Parse(b_s);

Console.Write("max = ");
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}