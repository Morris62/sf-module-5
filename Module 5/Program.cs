 namespace Module_5;

class Program
{
    static void Main(string[] args)
    {
        var array = GetArrayFromConsole(10);
        ShowArray(array, true);
    }
    private static void ShowArray(int[] array, bool IsSort = false)
    {
        var temp = array;
        if (IsSort)
        {
            temp = SortArray(array);
        }
        
        foreach (var item in temp) 
        {
            Console.WriteLine(item);
        }
    }
    private static int[] SortArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
        }

        return array;
    }
    private static int[] GetArrayFromConsole(int size = 5)
    {
        var array = new int[size];
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива номер {i}: ");
            array[i] = int.TryParse(Console.ReadLine(), out var result) ? result : 0;
        }
        return array;
    }
}