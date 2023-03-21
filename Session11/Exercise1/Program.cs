using System;

public class Program
{
    static void Main(string[] args)
    {
        int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
        int[] sortedArray = { 11, 12, 22, 25, 34, 64, 90 };
        int target = 64;

        Console.WriteLine("Unsorted array:");
        foreach (int number in unsortedArray)
        {
            Console.Write(number + " ");
        }

        BubbleSort.Sort(unsortedArray);

        Console.WriteLine("\nSorted array (after BubbleSort):");
        foreach (int number in unsortedArray)
        {
            Console.Write(number + " ");
        }

        int result = BinarySearch.Search(sortedArray, target);

        if (result != -1)
        {
            Console.WriteLine($"\nElement {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"\nElement {target} not found in the array");
        }
    }
}