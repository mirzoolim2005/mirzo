// See https://aka.ms/new-console-template for more information

Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
Console.Write("c=");
int c = int.Parse(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("adadi frqkunanda= " + c);
}
else if (b == c)
{
    Console.WriteLine("adadi frqkunanda= " + a);
}
else if (a == c)
{
    Console.WriteLine("adadi frqkunanda= " + b);
}
else
{
    Console.WriteLine("adadho az eakdigar farq mekunad= " + a+" "+b+" "+c);
}