class Karte
{
    public string Symbol { get; set; }
    public string Farbe { get; set; }
    public string Wert { get; set; }

    public Karte (string symbol, string farbe, string wert)
    {
        Symbol = symbol;
        Farbe = farbe;
        Wert = wert;
    }
}

class Skat
{
    static void Main()
    {
        string[] farben = { "Herz", "Kreuz", "Pik", "Karo" };
        string[] symbole = { "7", "8", "9", "10", "Bube", "Dame", "König", "Ass" };
        
        foreach (string farbe in farben)
        {
            foreach (string symbol in symbole)
            {
                int wert = 0;
                switch (symbol)
                {
                    case "10": wert = 10; break;
                    case "Bube": wert = 2; break;
                    case "Dame": wert = 3; break;
                    case "König": wert = 4; break;
                    case "Ass": wert = 11; break;
                }
                Karte k = new Karte(symbol, farbe, wert);
                Console.WriteLine("Karte: " + k);
            }
        }
    }
}