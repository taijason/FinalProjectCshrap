using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5, 2, 4, 6, 8, 4, 2, 1, 3, 5, 7, 9, 5, 3, 1 };

        // a. Determine the longest sequence of increasing length values in a sequence of integer values
        int[] longestSequence = FindLongestIncreasingSequence(data);
        Console.WriteLine("Longest increasing sequence: " + string.Join(", ", longestSequence));

        // b. Find the number of times a value appears in a range of values
        int value = 3;
        int occurrenceCount = CountOccurrences(data, value);
        Console.WriteLine("Number of occurrences of value " + value + ": " + occurrenceCount);

        // c. Delete duplicate values in range s6
        int[] uniqueValues = RemoveDuplicates(data);
        Console.WriteLine("Unique values in the range: " + string.Join(", ", uniqueValues));
    }

    // a. Determine the longest sequence of increasing length values in a sequence of integer values
    public static int[] FindLongestIncreasingSequence(int[] arr)
    {
        List<int> currentSequence = new List<int>();
        List<int> longestSequence = new List<int>();

        foreach (int value in arr)
        {
            if (currentSequence.Count == 0 || value > currentSequence.Last())
            {
                currentSequence.Add(value);
            }
            else
            {
                if (currentSequence.Count > longestSequence.Count)
                    longestSequence = new List<int>(currentSequence);

                currentSequence.Clear();
                currentSequence.Add(value);
            }
        }

        if (currentSequence.Count > longestSequence.Count)
            longestSequence = new List<int>(currentSequence);

        return longestSequence.ToArray();
    }

    // b. Find the number of times a value appears in a range of values
    public static int CountOccurrences(int[] arr, int value)
    {
        int count = 0;

        foreach (int v in arr)
        {
            if (v == value)
                count++;
        }

        return count;
    }

    // c. Delete duplicate values in range s6
    public static int[] RemoveDuplicates(int[] arr)
    {
        List<int> uniqueValues = arr.Distinct().ToList();

        return uniqueValues.ToArray();
    }
}