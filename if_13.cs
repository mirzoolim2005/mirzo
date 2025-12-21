// See https://aka.ms/new-console-template for more information

Console.Write("a= ");
int a=int.Parse(Console.ReadLine());
Console.Write("b= ");
int b=int.Parse(Console.ReadLine());
Console.Write("c= ");
int c=int.Parse(Console.ReadLine());
if (b<a && a<c)
{
    Console.WriteLine("Kimati miyona: " + a);
}
else if (a<b && b<c)
{
    Console.WriteLine("Kimati miyona: " + b);
}
else
{
    Console.WriteLine("Kimati miyona: " + c);
}