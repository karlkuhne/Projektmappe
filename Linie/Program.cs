class Punkt
{
    private int x;
    private int y;

    public Punkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int GetX() { return x; }
    public int GetY() { return y; }

    public void SetX(int x) { this.x = x; }
    public void SetY(int y) { this.y = y; }

    public void Move(int dx, int dy)
    {
        x = x + dx;
        y = y + dy;
    }
}

class Linie
{
    private Punkt anfang;
    private Punkt ende;

    public Linie(Punkt anfang, Punkt ende)
    {
        this.anfang = anfang;
        this.ende = ende;
    }

    public Punkt GetAnfang() { return anfang; }
    public Punkt GetEnde() { return ende; }

    public double BerechneLaenge()
    {
        int dx = anfang.GetX() - ende.GetX();
        int dy = anfang.GetY() - ende.GetY();
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

class Rechteck
{
    Punkt a, b, c, d;
    public Rechteck(Punkt a, Punkt b, Punkt c, Punkt d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }
    public double BerechneUmfang()
    {
        Linie l1 = new Linie(a, b);
        Linie l2 = new Linie(b, c);
        Linie l3 = new Linie(c, d);
        Linie l4 = new Linie(d, a);
        double umfang = l1.BerechneLaenge() + l2.BerechneLaenge() + l3.BerechneLaenge() + l4.BerechneLaenge();
        return umfang;
    }

    public void Move(int dx, int dy)
    {
        a.Move(dx, dy);
        b.Move(dx, dy);
        c.Move(dx, dy);
        d.Move(dx, dy);
    }
}

class Program
{
    public static void Main()
    {
        Punkt a = new Punkt(5, 3);
        Punkt b = new Punkt(2, 7);
        Punkt c = new Punkt(1, 1);
        Punkt d = new Punkt(10, 10);
        Rechteck r = new Rechteck(a, b, c, d);
        Console.WriteLine(r.BerechneUmfang());
        r.Move(2, 2);
    }
}