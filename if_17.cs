// See https://aka.ms/new-console-template for more information


Console.Write("a= ");
double a = double.Parse(Console.ReadLine());
Console.Write("b= ");
double b = double.Parse(Console.ReadLine());
Console.Write("c= ");
double c = double.Parse(Console.ReadLine());

if (a < b && b < c)
{
    a *= 2; b *= 2; c *= 2;
    Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
}
else if (a > b && b > c)
{
    a *= 2; b *= 2; c *= 2;
    Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
}
else if (a > 0 && b > 0 && c > 0)
{
    a = -a; b = -b; c = -c;
    Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
}