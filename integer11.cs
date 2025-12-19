// See https://aka.ms/new-console-template for more information

Console.Write("adadi seraqama: ");
int a=int.Parse(Console.ReadLine());
int vohid = a % 10;
Console.WriteLine(vohid);
int dahi = (a / 10) % 10;
Console.WriteLine(dahi);
int sadi = a / 100;
Console.WriteLine(sadi);
Console.WriteLine("summa= "+(vohid+dahi+sadi));
Console.WriteLine("hosili zarb= "+(vohid*dahi*sadi));