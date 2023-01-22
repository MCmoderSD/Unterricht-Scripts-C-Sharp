namespace Unterricht;

public class Kontostand
{ 
    public Kontostand()
    {
        Console.WriteLine("\n\nKontostand");
        Console.WriteLine("Enter your name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your Kontostand");
        var balance = Convert.ToDouble(Console.ReadLine());
        if (balance < 0)
        {
            Console.WriteLine("\n\n" + name + " your Account Balance is negative" + balance + "€, you are in debt!");
        }
        else if (balance == 0)
        {
            Console.WriteLine("\n\n" + name + " your Account Balance is 0€, you are just broke!");
        }
        {
            Console.WriteLine("\n\n" + name + " your Account Balance is positive" + balance + "€, you are rich!");
        }
        Console.WriteLine("\n\nPress any key to continue");
        Console.ReadKey();
        new Program();
    }
}