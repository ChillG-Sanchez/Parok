using System;

class Program
{
    static void Main(string[] args)
    {
        var entry1 = new Entry<int, string>(1, "Első érték");
        var entry2 = new Entry<int, string>(2, "Második érték");
        var entry3 = new Entry<int, string>(3, "Harmadik érték");

        var parok = new Parok<int, string>();
        parok.HozzaAd(entry1);
        parok.HozzaAd(entry2);
        parok.HozzaAd(entry3);

        Console.WriteLine("Parok tartalma:");
        Console.WriteLine(parok);

        var keresettEntry = parok.Keres(2);
        Console.WriteLine("\nKeresett Entry kulcs alapján:");
        Console.WriteLine(keresettEntry);

        parok.Torol(entry2);
        Console.WriteLine("\nParok tartalma törlés után:");
        Console.WriteLine(parok);

        parok.TorolIndexAlapjan(0);
        Console.WriteLine("\nParok tartalma index alapján történő törlés után:");
        Console.WriteLine(parok);
    }
}