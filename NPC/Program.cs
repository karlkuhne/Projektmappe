using System.Threading.Channels;

// das ist alles nur geklaut

class NPC
{
    //name, alter, vater, mutter
    private string name;
    private int alter;
    private NPC vater;
    private NPC mutter;

    //Konstruktor
    public NPC(string name, int alter)
    {
        this.name = name;
        this.alter = alter;
    }

    //Getter
    public string GetName() { return name; }
    public int GetAlter() { return alter; }
    public NPC GetVater() { return vater; }
    public NPC GetMutter() { return mutter; }

    //Setter
    public void SetName(string name) { Console.WriteLine("Namensänderungen sind nicht erlaubt."); }
    public void SetAlter(int alter) { Console.WriteLine("Das Alter darf nicht manuell geändert werden."); }
    public bool HatEltern()
    {
        if (mutter != null && vater != null) return true;
        else return false;
    }
    public void SetVater(NPC vater)
    {
        if (!vater.Equals(this))
        {
            if (vater.GetAlter() > alter)
            {
                if (mutter != null && mutter.HatEltern() && vater.HatEltern())
                {
                    if (vater.GetVater().Equals(mutter.GetVater()) &&
                        vater.GetMutter().Equals(mutter.GetMutter()))
                    {
                        Console.WriteLine("Das ist verboten.");
                    }
                    else
                    {
                        this.vater = vater;
                    }
                }
                else
                {
                    this.vater = vater;
                }
            }
            else
            {
                Console.WriteLine("Der Vater muss älter als seine Kinder sein.");
            }
        }
    }
    public void SetMutter(NPC mutter)
    {
        if (mutter.GetAlter() > alter)
        {
            if (vater != null && vater.HatEltern() && mutter.HatEltern())
            {
                if (vater.GetVater().Equals(mutter.GetVater()) &&
                    vater.GetMutter().Equals(mutter.GetMutter()))
                {
                    Console.WriteLine("Das ist verboten.");
                }
                else
                {
                    Console.WriteLine("ok");
                    this.mutter = mutter;
                }
            }
            else
            {
                this.mutter = mutter;
            }
        }
        else
        {
            Console.WriteLine("Die Mutter muss älter als ihre Kinder sein.");
        }
    }
}

class Program
{
    public static void Main()
    {
        NPC anna = new NPC("Anna", 21);
        NPC paul = new NPC("Paul", 24);
        NPC eike = new NPC("Eike", 22);
        NPC hans = new NPC("Hans", 5);
        NPC erwin = new NPC("Erwin", 6);
        NPC freya = new NPC("Freya", 4);
        NPC maya = new NPC("Maya", 5);
        NPC gernot = new NPC("Gernot", 40);
        NPC torben = new NPC("Torben", 42);
        NPC irmgart = new NPC("Irmgart", 41);
        NPC ulrike = new NPC("Ulrike", 43);

        anna.SetVater(gernot);
        anna.SetMutter(irmgart);
        paul.SetVater(gernot);
        paul.SetMutter(irmgart);
        eike.SetVater(torben);
        eike.SetMutter(ulrike);
        hans.SetVater(torben);
        hans.SetMutter(ulrike);

        erwin.SetVater(paul);
        erwin.SetMutter(anna);
    }
}