using System.Runtime.CompilerServices;

namespace Module_5;

class Program
{
    static void Main(string[] args)
    {
        var (name, age) = ("Евгения", 27);
        
        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.WriteLine("Введите имя:");
        name = GetDataFromConsole();
        Console.WriteLine("Введите возраст:");
        age = int.TryParse(GetDataFromConsole(), out var _age) ? _age : 0;
        
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваше возраст: {0}", age);
        
        var favcolor = new string[3];
        for (int i = 0; i < favcolor.Length; i++)
        {
            Console.WriteLine("Введите ваш любимый цвет {0}:", i + 1);
            favcolor[i] = ShowColor();
        }

        Console.WriteLine("Ваши любимые цвета: ");
        foreach (var color in favcolor)
        {
            Console.WriteLine(color);
        }
        Console.ReadKey();
    }

    private static string ShowColor()
    {
        Console.WriteLine("Введите свой любимый цвет на английском языке с маленькой буквы");
        var color = GetDataFromConsole();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.WriteLine("Your favourite color is red");
                break;
            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.WriteLine("Your favourite color is green");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.WriteLine("Your favourite color is cyan");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine("Your favourite color is yellow");
                break;
        }

        Console.ResetColor();
        return color;
    }

    private static string? GetDataFromConsole()
    {
        return Console.ReadLine();
    }
}