namespace Module_5;

class Program
{
    static void Main(string[] args)
    {
        var user = GetPersonInfo();
        ShowPersonInfo(user);
    }

    private static void ShowPersonInfo(
        (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) user)
    {
        Console.WriteLine();
        Console.WriteLine($"Ваше имя: {user.Name}");
        Console.WriteLine($"Ваша фамилия: {user.LastName}");
        Console.WriteLine($"Ваш возраст: {user.Age}");
        
        if (user.PetNames.Length > 0)
        {
            Console.Write("Ваши питомцы:");
            foreach (var pet in user.PetNames)
                Console.Write(" {0}", pet);
            Console.WriteLine();
        }

        Console.Write("Ваши любимые цвета:");
        foreach (var color in user.FavColors)
            Console.Write(" {0}", color);
        
        /*
        foreach (var pet in user.PetNames)
            Console.WriteLine($"У Вас есть питомец: {pet}");
        foreach (var color in user.FavColors)
            Console.WriteLine($"Ваш любимый цвет: {color}");
        //*/
    }

    static (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) GetPersonInfo()
    {
        (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User;
        
        Console.WriteLine("Введите ваше имя:");
        User.Name = Console.ReadLine();
        
        Console.WriteLine("Введите вашу фамилию:");
        User.LastName = Console.ReadLine();
        
        Console.WriteLine("Введите ваш возраст (положительное число):");
        User.Age = ReadNumber();
        
        Console.WriteLine("У вас есть домашнее животное? (Да/Нет)");
        int count = 0;
        if (Console.ReadLine().ToLower() == "да")
        {
            Console.WriteLine("Введите количество питомцев (положительное число):");
            count = ReadNumber();
        }
        User.PetNames = GetPetNames(count);

        Console.WriteLine("Введите количество любимых цветов (положительное число):");   
        count = ReadNumber();
        User.FavColors = GetFavColors(count);
        
        return User;
    }

    private static string[] GetFavColors(int count)
    {
        var favColors = new string[count];
        for (int i = 0; i < favColors.Length; i++)
        {
            Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
            favColors[i] = Console.ReadLine();
        }
        return favColors;
    }

    private static string[] GetPetNames(int count)
    {
        var pets = new string[count];
        for (int i = 0; i < pets.Length; i++)
        {
            Console.WriteLine("Введите кличку питомца номер {0}", i + 1);
            pets[i] = Console.ReadLine();
        }
        return pets;
    }

    private static int ReadNumber()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (CheckNum(input, out int result))
                return result;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            Console.ResetColor();
        }
    }

    static bool CheckNum(string str, out int num) => int.TryParse(str, out num) && num > 0;
}