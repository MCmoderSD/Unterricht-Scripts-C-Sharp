namespace Unterricht;

public class Lotto
{
    short[] lottozahlen = new short[6];
    public Lotto()
    {
        Console.WriteLine("\n\nLottozahlen");
        Console.WriteLine("Die Lottozahlen sind: \n");
        Console.WriteLine(generiereLottozahlen());
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        new Program();
    }
    string generiereLottozahlen()
    {
        Random rnd = new Random();
        string lottozahlenString = "";
        bool hatDoppelte = false;
        for (var i = 0; i < lottozahlen.Length; i++)
        {
            lottozahlen[i] = (short)rnd.Next(1, 49);
            lottozahlenString += lottozahlen[i] + " ";
            for (var j = 0; j < i; j++)
            {
                hatDoppelte = lottozahlen[i] == lottozahlen[j];
            }
            if (hatDoppelte)
            {
                hatDoppelte=false;
                Console.WriteLine("Doppelte Zahl gefunden!: " + lottozahlen[i]);
            } else
            {
                i++;
            }
            
        }
        return lottozahlenString;
    }
}