abstract class Einwohner
{
    int einkommen;
    public string name;

    public Einwohner(int einkommen, string name)
    {
        this.einkommen = einkommen;
        this.name = name;
    }

    public void SetEinkommen (int einkommen)
    {
        this.einkommen = einkommen;
    }

    public int GetEinkommen ()
    {
        return this.einkommen;
    }

    public virtual int zuVersteuerndesEinkommen() { return this.einkommen; } // Standardfall: Gesamtes Einkommen versteuern

    public virtual int Steuer() { return this.zuVersteuerndesEinkommen() / 10; } // Standarfall: 10% Steuersatz

}

class Koenig : Einwohner
{
    public Koenig(int einkommen, string name) : base(einkommen, name) { }
    public override int zuVersteuerndesEinkommen()
    {
        return 0;
    }
}

class Adel : Einwohner
{
    public Adel(int einkommen, string name) : base(einkommen,  name) { }

    public override int Steuer()
    {
        if (base.Steuer() < 20) return 20; else return base.Steuer();
    }
}

class Bauer : Einwohner
{
    public Bauer(int einkommen, string name) : base(einkommen,  name) { }
}

class Leibeigener : Einwohner
{
    public Leibeigener(int einkommen, string name) : base(einkommen, name) { }

    public override int zuVersteuerndesEinkommen()
    {
        return base.zuVersteuerndesEinkommen() -12;
    }
}

class Koenigreich
{
    public static void Steuerbescheid(Einwohner einwohner)
    {
        Console.WriteLine(einwohner.name);
        Console.WriteLine("Einkommen: " + einwohner.GetEinkommen());
        Console.WriteLine("Davon zu versteuern: " + einwohner.zuVersteuerndesEinkommen());
        Console.WriteLine("Zu entrichtende Steuern: " + einwohner.Steuer());
    }
    static void Main()
    {
        Einwohner Arthur = new Koenig(200, "Arthur");
        Einwohner Erik = new Bauer(50, "Erik");
        Einwohner Ek = new Leibeigener(25, "Ek");
        Einwohner Ulrike = new Adel(150, "Ulrike");

        Steuerbescheid(Arthur);
        Steuerbescheid(Erik);
        Steuerbescheid(Ek);
        Steuerbescheid(Ulrike);
    }
   
}

