class Spieler
{
    private string name;
    private Raum aktuellePosition;
}

class Raum
{
    private string text;
    private Raum vor, zurueck, links, rechts;

    // Konstruktor
    public Raum (string text)
    {
        this.text = text;
    }

    public Raum GetVor() { return vor; }
    public Raum GetZurueck() { return zurueck; }
    public Raum GetLinks() { return links; }
    public Raum GetRechts() { return rechts; }

    
    
}