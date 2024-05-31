abstract class Haustier
{
    private string name;
    private int alter;

    public Haustier (string name, int alter)
    {
        this.name = name;
        this.alter = alter;
    }

    public void setAlter(int a)
    {
        if (a >= 0) alter = a;
    }

    public void setName(string n)
    {
        name = n;
    }

    public abstract void sagHallo();
}

class Hund: Haustier
{
    public Hund(string name, int alter) : base(name, alter) { }

    public override void sagHallo()
    {
        Console.WriteLine("WauWau");
    }
}

class Katze : Haustier
{
    public Katze(string name, int alter) : base(name, alter) { }

    public override void sagHallo()
    {
        Console.WriteLine("MiauMiau");
    }
}

class Program
{
    static void Main()
    {
        Haustier bello = new Hund("Bello",10);

        Haustier kasimir = new Katze("Kasimir", 4);

        bello.sagHallo();
        kasimir.sagHallo();

    }
}