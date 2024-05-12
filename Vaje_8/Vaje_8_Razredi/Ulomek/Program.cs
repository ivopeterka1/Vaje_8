using System;

public class Ulomek
{
    public int Stevec { get; private set; }
    public int Imenovalec { get; private set; }

    public Ulomek(int stevec, int imenovalec)
    {
        if (imenovalec == 0)
        {
            throw new ArgumentException("Imenovalec ne sme biti 0.");
        }
        Stevec = stevec;
        Imenovalec = imenovalec;
    }

    public Ulomek Seštej(Ulomek drugi)
    {
        int novStevec = this.Stevec * drugi.Imenovalec + drugi.Stevec * this.Imenovalec;
        int novImenovalec = this.Imenovalec * drugi.Imenovalec;
        return new Ulomek(novStevec, novImenovalec);
    }

    public Ulomek Pomnoži(Ulomek drugi)
    {
        return new Ulomek(this.Stevec * drugi.Stevec, this.Imenovalec * drugi.Imenovalec);
    }



    public override string ToString()
    {
        return $"{Stevec}/{Imenovalec}";
    }
}

class Program
{
    static void Main()
    {
        Ulomek u1 = new Ulomek(1, 2);
        Ulomek u2 = new Ulomek(3, 4);

        Ulomek sum = u1.Seštej(u2);
        Ulomek product = u1.Pomnoži(u2);

        Console.WriteLine($"Seštevek ulomkov {u1} in {u2} je {sum}");
        Console.WriteLine($"Produkt ulomkov {u1} in {u2} je {product}");
    }
}
