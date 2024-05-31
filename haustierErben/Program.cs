abstract class Haustier
{
    private string name;

    public Haustier(string name)
    {
        this.name = name;
    }

    public virtual void SagHallo()
    {
        Console.Write("[" + name + "]: ");
    }
}

class Hund : Haustier
{
    private int nummer;
    public Hund(string name, int nummer) : base(name)
    {
        this.nummer = nummer;
    }
    public override void SagHallo()
    {
        base.SagHallo();
        Console.WriteLine("Wuff");
    }

    public void Gassi()
    {
        Console.WriteLine("Freu");
    }
}

class Katze : Haustier
{
    public Katze(string name) : base(name) { }
    public override void SagHallo()
    {
        base.SagHallo();
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main()
    {
        Haustier bello = new Hund("Bello", 420);
        Haustier minka = new Katze("Minka");
        Haustier fritz = new Hund("Fritz", 120);

        bello.SagHallo();
        minka.SagHallo();
        fritz.SagHallo();

    }
}