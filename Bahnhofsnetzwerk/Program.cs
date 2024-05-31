class Bahnhof
{
    private string name;
    private int x, y;
    private Bahnhof[] nachbarn;
    private int anzahlNachbarn;

    public Bahnhof(string name, int x, int y)
    {
        this.name = name;
        this.x = x;
        this.y = y;
        nachbarn = new Bahnhof[5];
        anzahlNachbarn = 0;
    }

    //Getter
    public string GetName() { return name; }
    public int getX() { return x; }
    public int getY() { return y; }
    public int getAnzahlNachbarn() { return anzahlNachbarn; }

    //Setter

    public void SetName(string name) { this.name = name; }
    public void setX(int x) { this.x = x; }
    public void setY(int y) { this.y = y; }

    // Array
    public void addNachbar(Bahnhof new_nachbar)
    {
        this.nachbarn[anzahlNachbarn++] = new_nachbar;
    }

    // Beschreiben
    public void beschreibeDich()
    {
        Console.WriteLine("Der Bahnhof " + this.name + " hat " + this.anzahlNachbarn + " Nachbarn.");
    }
}

class Program
{
    public static void Main()
    {
        Bahnhof dd = new Bahnhof("Dresden", 10, 10);
        Bahnhof b = new Bahnhof("Berlin", 10, 5);
        Bahnhof m = new Bahnhof("Muenchen", 10, 15);
        Bahnhof hh = new Bahnhof("Hamburg", 5, 5);
        Bahnhof r = new Bahnhof("Ruhland", 10, 9);
        Bahnhof h = new Bahnhof("Hof", 5, 10);

        dd.addNachbar(r);
        dd.addNachbar(h);

        r.addNachbar(b);
        r.addNachbar(hh);

        h.addNachbar(m);

        dd.beschreibeDich();
        r.beschreibeDich();

    }
}