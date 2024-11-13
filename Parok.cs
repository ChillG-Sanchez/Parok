using System;
using System.Collections.Generic;

public class Parok<K, E>
{
    private List<Entry<K, E>> lista;

    public Parok()
    {
        lista = new List<Entry<K, E>>();
    }

    public void HozzaAd(Entry<K, E> entry)
    {
        lista.Add(entry);
    }

    public void Torol(Entry<K, E> entry)
    {
        lista.Remove(entry);
    }

    public void TorolIndexAlapjan(int index)
    {
        if (index >= 0 && index < lista.Count)
        {
            lista.RemoveAt(index);
        }
    }

    public Entry<K, E>? Keres(K kulcs)
    {
        return lista.Find(entry => entry.Kulcs?.Equals(kulcs) ?? false);
    }

    public override string ToString()
    {
        return string.Join(", ", lista);
    }
}