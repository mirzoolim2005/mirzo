// See https://aka.ms/new-console-template for more information


int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
if  (a > b)
{
    a=a; b=a;
    Console.WriteLine("a= " + a + "  b=" + b);
}
else if  (b > a)
{
    a = b; b = b;
    Console.WriteLine("a= " + a + "  b=" + b);
}
else { a = 0;b = 0; Console.WriteLine("a= " + a + "  b=" + b); }