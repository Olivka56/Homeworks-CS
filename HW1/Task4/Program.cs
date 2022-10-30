Console.Write("a= ");
string a_s = Console.ReadLine();
int a = int.Parse(a_s);

Console.Write("b= ");
string b_s = Console.ReadLine();
int b = int.Parse(b_s);

Console.Write("c= ");
string c_s = Console.ReadLine();
int c = int.Parse(c_s);

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}