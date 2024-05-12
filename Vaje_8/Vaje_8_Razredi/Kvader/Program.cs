using System;

public class Kvader : IComparable<Kvader>
{
    public double Dolzina { get; set; }
    public double Sirina { get; set; }
    public double Visina { get; set; }

    public Kvader(double dolzina, double sirina, double visina)
    {
        Dolzina = dolzina;
        Sirina = sirina;
        Visina = visina;
    }

    public double Prostornina()
    {
        return Dolzina * Sirina * Visina;
    }

    public static Kvader operator *(Kvader kvader, int faktor)
    {
        return new Kvader(kvader.Dolzina * faktor, kvader.Sirina * faktor, kvader.Visina * faktor);
    }

    public int CompareTo(Kvader other)
    {
        return this.Prostornina().CompareTo(other.Prostornina());
    }

    public override string ToString()
    {
        return $"Kvader({Dolzina} x {Sirina} x {Visina})";
    }
}

class Program
{
    static void Main()
    {
        Kvader kvader1 = new Kvader(2, 3, 5);
        Kvader kvader2 = new Kvader(3, 2, 1);

        Console.WriteLine($"Prostornina kvadra 1: {kvader1.Prostornina()}");
        Console.WriteLine($"Prostornina kvadra 2: {kvader2.Prostornina()}");

        Kvader vecjiKvader = kvader1 * 2;
        Console.WriteLine($"Prostornina povečanega kvadra: {vecjiKvader.Prostornina()}");

        int comparison = kvader1.CompareTo(kvader2);
        if (comparison > 0)
        {
            Console.WriteLine("Kvader 1 ima večjo prostornino kot Kvader 2.");
        }
        else if (comparison < 0)
        {
            Console.WriteLine("Kvader 2 ima večjo prostornino kot Kvader 1.");
        }
        else
        {
            Console.WriteLine("Oba kvadra imata enako prostornino.");
        }
    }
}
