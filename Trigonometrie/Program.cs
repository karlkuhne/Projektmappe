//Klassen für Form 
//- Quadrat - welche Attribute gibt es?
//- Kreis - welche Attribute gibt es?
//- Dreieck - welche Attribute gibt es?
//Formen haben eine Methode "GetFläche()"

abstract class Form
{
    public abstract double GetFläche();
}

class Quadrat : Form
{
    private int laenge;

    public Quadrat(int laenge)
    {
        this.laenge = laenge;
    }

    public override double GetFläche()
    {
        return laenge * laenge;
    }
}

class Kreis : Form
{
    private double radius;

    public Kreis(double radius)
    {
        this.radius = radius;
    }

    public override double GetFläche()
    {
        return Math.PI * radius * radius;
    }
}

class Dreieck : Form
{
    Punkt a, b, c;
    public Dreieck(Punkt a, Punkt b, Punkt c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double GetFläche()
    {
        Linie l1 = new Linie(a, b);
        Linie l2 = new Linie(b, c);
        Linie l3 = new Linie(c, a);

        double la = l1.GetLaenge();
        double lb = l2.GetLaenge();
        double lc = l3.GetLaenge();

        double g = Math.Acos((la * la + lb * lb - lc * lc) / (2 * la * lb));
        double h = lb * Math.Sin(g);
        double f = la * h / 2;

        return f;
    }
}

class Viereck : Form
{
    Punkt a, b, c, d;
    public Viereck(Punkt a, Punkt b, Punkt c, Punkt d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }
    public override double GetFläche()
    {
        Dreieck links = new Dreieck(a, b, c);
        Dreieck rechts = new Dreieck(a, c, d);
        return links.GetFläche() + rechts.GetFläche();
    }
}

class Punkt
{
    int x, y;

    public Punkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int GetX() { return x; }
    public int GetY() { return y; }
}

class Linie
{
    Punkt a, b;
    public Linie(Punkt a, Punkt b)
    {
        this.a = a;
        this.b = b;
    }
    public double GetLaenge()
    {
        int dx = a.GetX() - b.GetX();
        int dy = a.GetY() - b.GetY();
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

class Program
{
    static void Main()
    {
        Form f1 = new Kreis(4.0);
        Form f2 = new Quadrat(2);
        Form f3 = new Dreieck(new Punkt(1, 1), new Punkt(3, 5), new Punkt(5, 1));
        Form f4 = new Viereck(new Punkt(1, 1), new Punkt(4, 1), new Punkt(4, 4), new Punkt(1, 4));

        Form[] forms = { f1, f2, f3, f4 };

        double gesamt = 0.0;
        foreach (Form f in forms)
        {
            gesamt += f.GetFläche();
            Console.WriteLine(f.GetFläche());
        }
        Console.WriteLine("Gesamtfläche: " + gesamt);
    }
}