using System;
namespace HalloFHD
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hallo FHD.");
            bool hatGeklappt;
            int versuche=1;

            do
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                string nutzereingabe = Console.ReadLine();
                int meineZahl = 0;
                hatGeklappt = int.TryParse(nutzereingabe, out meineZahl);

                if (hatGeklappt)
                {
                    if (versuche>1)
                    {
                        Console.WriteLine("Geht doch!. Du hast " + versuche + " Versuche gebraucht.");
                    }
                    Console.WriteLine("Sie haben " + meineZahl + " eingebeben.");
                }
                else
                {
                    versuche++;
                }
            }

            while (!hatGeklappt);
            
        }
    }
}