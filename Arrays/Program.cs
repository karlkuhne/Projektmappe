class Test
{
    static void Untersuche(int z)
    {
        if (z>10)
        {
            Console.Write("X ");
        } else
        {
            Console.Write("- ");
        }
    }
    static void Main()
    {
        int[] lottozahlen = { 5,47,9,23,1,99 };
        foreach (int zahl in lottozahlen)
        {
            Untersuche(zahl);
        }
    }
}
