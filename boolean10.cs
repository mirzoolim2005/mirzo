// See https://aka.ms/new-console-template for more information


Console.Write("adadi butun: a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("adadi butun: b= ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("tanho yake toq: " + ((a % 2 != 0 && b % 2 == 0) || (a % 2 == 0 && b % 2 != 0)));