using System.Runtime.CompilerServices;

namespace Module_5;

class Program
{
    static void Main(string[] args)
    {
        var unsortedArray = GetArrayFromConsole();
        var sortedArray = GetSortedArray(in unsortedArray);
        //var sortedArray = unsortedArray.OrderBy(x => x).ToArray();

        foreach (var item in sortedArray) 
        {
            Console.Write("{0} ", item);
        }
    }

    private static int[] GetSortedArray(in int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }

    private static int[] GetArrayFromConsole()
    {
        var array = new int[10];
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива {i}: ");
            array[i] = int.TryParse(Console.ReadLine(), out var result) ? result : 0;
        }
        return array;
    }
}