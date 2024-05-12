using System;

public class Kocka : IComparable<Kocka>
{
    public double DolzinaStranice { get; private set; }

    public Kocka(double dolzinaStranice)
    {
        if (dolzinaStranice <= 0)
        {
            throw new ArgumentException("Dolžina stranice mora biti večja od 0.");
        }
        DolzinaStranice = dolzinaStranice;
    }

    public double Prostornina()
    {
        return Math.Pow(DolzinaStranice, 3);
    }

    public int CompareTo(Kocka other)
    {
        if (other == null) return 1;
        return Prostornina().CompareTo(other.Prostornina());
    }

    public override string ToString()
    {
        return $"Kocka z dolžino stranice {DolzinaStranice}, prostornina: {Prostornina()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kocka kocka1 = new Kocka(3);
        Kocka kocka2 = new Kocka(4);
        Kocka kocka3 = new Kocka(2);

        Kocka[] kocke = new Kocka[] { kocka1, kocka2, kocka3 };
        Array.Sort(kocke);

        Console.WriteLine("Kocke razvrščene po prostornini:");
        foreach (Kocka kocka in kocke)
        {
            Console.WriteLine(kocka);
        }
    }
}
