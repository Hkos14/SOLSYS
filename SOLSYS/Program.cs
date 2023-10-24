// See https://aka.ms/new-console-template for more information
using SOLSYS;
using System.Text;
using System.Linq;
using System.Threading.Channels;

List<Bolygo> bolygok = new List<Bolygo>();

using (StreamReader sr = new(path: @"..\..\..\src\_SOLSYS\solsys.txt"))
while (!sr.EndOfStream)
    bolygok.Add(new Bolygo(sr.ReadLine()));

Console.WriteLine($"3.1 feladat: {bolygok.Count} db bolygó található a naprendszerben");

var holdak = bolygok.Average(b => b.Szama);
Console.WriteLine($"3.2 feladat: A naprendszerben egy bolygónak átlagosan: {holdak} holdja van.");

var legnagyobb = bolygok.Max(b => b.Terfogat);
Console.WriteLine($"3.3 feladat: A legnagyobb térfogatú bolygó a: {legnagyobb}");


Console.WriteLine("Ird be a keresett bolygó nevét: (Plútó)");
var bolygonev = Console.ReadLine();

foreach (var b in bolygok)
{
    if (bolygonev != null)
    {
        Console.WriteLine(" 3.4 feladat: A bolygó nem található a naprendszerben");
        
    }
    break;
}


Console.WriteLine("3.5 feladat: Irj be egy egész számot: (10)");
int holdakszama = int.Parse(Console.ReadLine());

foreach (var i in bolygok)
{
    if (i.Szama > holdakszama)
    {
        Console.Write($" '{i.Neve} ',");
    }
}




