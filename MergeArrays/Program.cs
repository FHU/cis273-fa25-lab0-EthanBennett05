using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 0, 2, 4, 6 };
        int[] array2 = { 1, 3, 5, 7 };
        Console.WriteLine(MergeSortedArrays(array1, array2));

        int[] array4 = { };
        int[] array5 = { 1, 2, 3, 9 };
        //int[] expectedResult = { 1, 2, 3, 9 };
        Console.WriteLine(MergeSortedArrays(array4, array5));
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        return array1.Concat(array2).OrderBy(x => x).ToArray();
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        return true;
    }
}

