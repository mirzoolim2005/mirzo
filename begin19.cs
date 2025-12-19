// See https://aka.ms/new-console-template for more information

Console.Write("x1= ");
int x1=int.Parse(Console.ReadLine());
Console.Write("x2= ");
int x2=int.Parse(Console.ReadLine());
Console.Write("y1= ");
int y1=int.Parse(Console.ReadLine());
Console.Write("y2= ");
int y2=int.Parse(Console.ReadLine());

double a = Math.Abs(x2 - x1);
double b = Math.Abs(y2 - y1);

Console.WriteLine("perimetir: " + (2 * (a + b)));
Console.WriteLine("masohat: " + (a + b));