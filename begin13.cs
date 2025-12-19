// See https://aka.ms/new-console-template for more information

Console.Write("radiusi doirai r1 (r1 > r2): ");
int r1= int.Parse(Console.ReadLine());
Console.Write("radiusi doirai r1 (r1 > r2): ");
int r2= int.Parse(Console.ReadLine());
double pi = 3.14;
double s1 = pi * (r1 * r1);
Console.WriteLine("masohati doirai r1: " + s1);
double s2 = pi * (r2 * r2);
Console.WriteLine("masohati doirai r2: " + s2);
double s3 = (s1 - s2);
Console.WriteLine("masohati halqa: " + s3);