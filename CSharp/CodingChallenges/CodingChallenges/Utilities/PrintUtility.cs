﻿
namespace CodingChallenges.Utilities;

internal static class PrintUtility
{
    public static void PrintPrimitiveList<T>(IList<T> array)
    {
        if (array.Count == 0)
        {
            Console.Write("[]");
            return;
        }

        Console.Write("[");

        for (var index = 0; index < array.Count; index++)
        {
            if (index != array.Count - 1)
            {
                Console.Write($"{array[index]}, ");
            }
            else
            {
                Console.Write($"{array[index]}]");
            }
        }
    }

    public static void PrintPrimitiveArray<T>(T[] array)
    {
        Console.Write("[");
        for (var index = 0; index < array.Length; index++)
        {
            if (index != array.Length - 1)
            {
                Console.Write($"{array[index]}, ");
            }
            else
            {
                Console.Write($"{array[index]}]");
            }
        }
    }
}
