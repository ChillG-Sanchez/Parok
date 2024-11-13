public class Entry<K, E>
{
    public K Kulcs { get; }
    public E Ertek { get; }

    public Entry(K kulcs, E ertek)
    {
        Kulcs = kulcs;
        Ertek = ertek;
    }

    public override string ToString()
    {
        return $"Kulcs: {Kulcs}, Érték: {Ertek}";
    }
}