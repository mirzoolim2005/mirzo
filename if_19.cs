// See https://aka.ms/new-console-template for more information


Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
Console.Write("c=");
int c = int.Parse(Console.ReadLine());
Console.Write("d=");
int d = int.Parse(Console.ReadLine());
if (b == c && c==d && b==d)
{
    Console.WriteLine("adadi frqkunanda= " + a);
}
else if (a == c && c == d && a == d)
{
    Console.WriteLine("adadi frqkunanda= " + b);
}
else if (a == b && b == d && a == d)
{
    Console.WriteLine("adadi frqkunanda= " + c);
}
else if (a == b && b == c && a == c)
{
    Console.WriteLine("adadi frqkunanda= " + d);
}
else
{
    Console.WriteLine("adadho az eakdigar farq mekunad= " + a + " " + b + " " + c+" "+d);
}