 namespace Module_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу:");
        var saidworld = Console.ReadLine();

        Console.WriteLine("Введите глубину эха:");
        var depth = int.TryParse(Console.ReadLine(), out var result) ? result : 0;

        Echo(saidworld, depth);
    }

    private static void Echo(string saidworld, int depth)
    {
        var modif = saidworld;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }
        Console.WriteLine("..." + modif);
        if (depth > 1)
        {
            Echo(modif, depth - 1);
        }
    }
}