using Unterricht;
ProgramSelector();

void ProgramSelector()
{
    Console.WriteLine("\n\n\nPick from a list of programs");
    Console.WriteLine("1. Hello World");
    Console.WriteLine("2. Kontostand");
    Console.WriteLine("3. Lotto");
    Console.WriteLine("4. NameAlter");
    Console.WriteLine("5. OddOrEven");
    Console.WriteLine("6. Rechner");
    Console.WriteLine("7. Shutdown");
    switch(Console.ReadLine())
    {
        case "1":
            new HelloWorld();
            break;
        case "2":
            new Kontostand();
            break;
        case "3":
            new Lotto(); 
            break;
        case "4":
            new NameAlter();
            break;
        case "5":
            new OddOrEven();
            break;
        case "6":
            new Rechner();
            break;
        case "7":
            new Shutdown();
            break;
        default:
            Console.WriteLine("Invalid input");
            ProgramSelector();
            break;
    }
}
