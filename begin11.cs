// See https://aka.ms/new-console-template for more information

Console.Write("qimati a-ro dokhil kuned: ");
int a = int.Parse(Console.ReadLine());
Console.Write("qimati b-ro dokhil kuned: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("summai a va b: " + (a + b));
Console.WriteLine("tarhi a va b: " + (a - b));
Console.WriteLine("zarbi a va b: " + (a * b));
Console.WriteLine("modul a va b:"+(Math.Abs(a)/Math.Abs(b)));