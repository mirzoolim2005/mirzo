// See https://aka.ms/new-console-template for more information

Console.Write("A= ");
int a=int.Parse(Console.ReadLine());
Console.Write("B= ");
int b = int.Parse(Console.ReadLine());
Console.Write("C= ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("darozii porchai AC " + (c - a));
Console.WriteLine("darozii porchai BC " + (c - b));
Console.WriteLine("summai onho: " + (a + b + c));