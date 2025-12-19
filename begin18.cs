// See https://aka.ms/new-console-template for more information


Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());
Console.Write("c= ");
int c = int.Parse(Console.ReadLine());
int ac = (c - a);
int bc = (b - c);
Console.WriteLine("ac: " + ac);
Console.WriteLine("bc: " + bc);
Console.WriteLine("hosili zarbi porchaho: " + (ac * bc));