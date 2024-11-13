using System;

class Program
{
    static void Main(string[] args)
    {
        // Létrehozunk néhány Entry példányt
        var entry1 = new Entry<int, string>(1, "Első érték");
        var entry2 = new Entry<int, string>(2, "Második érték");
        var entry3 = new Entry<int, string>(3, "Harmadik érték");

        // Létrehozzuk a Parok példányt és hozzáadjuk az Entry-ket
        var parok = new Parok<int, string>();
        parok.HozzaAd(entry1);
        parok.HozzaAd(entry2);
        parok.HozzaAd(entry3);

        // Kiírjuk a Parok tartalmát
        Console.WriteLine("Parok tartalma:");
        Console.WriteLine(parok);

        // Keresünk egy kulcs alapján
        var keresettEntry = parok.Keres(2);
        Console.WriteLine("\nKeresett Entry kulcs alapján:");
        Console.WriteLine(keresettEntry);

        // Törlünk egy Entry-t
        parok.Torol(entry2);
        Console.WriteLine("\nParok tartalma törlés után:");
        Console.WriteLine(parok);

        // Törlünk egy Entry-t index alapján
        parok.TorolIndexAlapjan(0);
        Console.WriteLine("\nParok tartalma index alapján történő törlés után:");
        Console.WriteLine(parok);
    }
}