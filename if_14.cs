// See https://aka.ms/new-console-template for more information

Console.Write("a=");
int a=int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
Console.Write("c=");
int c = int.Parse(Console.ReadLine());
if (a < b && a < c)
{
    Console.WriteLine("khurdtarin = " + a);
}
else if (b < a && b < c)
{
    Console.WriteLine("khurdtarin = " + b);
}
else if (c < b && c < a)
{
    Console.WriteLine("khurdtarin = " + c);
}
if (a > b && a > c)
{
    Console.WriteLine("kalontarin = " + a);
}
else if (b > a && b > c)
{
    Console.WriteLine("kalontarin = " + b);
}
else if (c > b && c > a)
{
    Console.WriteLine("kalontarin = " + c);
}