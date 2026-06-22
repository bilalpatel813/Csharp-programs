using System;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("Array");

        int[] number = new int[5];
        Console.WriteLine(number[4]);

        int[] filled = { 10, 20, 30 };

        Console.WriteLine(filled[0]);
        Console.WriteLine(filled[2]);

        filled[2] = 50;
        Console.WriteLine("Converted 30 to 50: " + filled[2]);

        string[] names = { "bilal", "adnan", "faiz", "gani" };

        Console.WriteLine("Head officer: " + names[0]);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Multi-dimensional Array
        Console.WriteLine("Multi-dimensional array");

        int[,] grid = new int[3, 3];

        grid[1, 2] = 5;
        grid[0, 0] = 1;

        Console.WriteLine("Accessing element of 2D array: " + grid[1, 2]);

        Console.WriteLine("2D Array:");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(grid[row, col] + " ");
            }

            Console.WriteLine();
        }

        // Jagged Array: - array of arrays
        int[][] jagged = new int[3][];

        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };

        // Row0 → [1, 2]
        // Row1 → [3, 4, 5]
        // Row2 → null

        Console.WriteLine("Second element of Row0: " + jagged[0][1]);

        // Sorting
        Console.WriteLine("Sorting");

        int[] nums = { 1, 2, 5, 6, 3, 7, 9, 8 };

        Console.WriteLine("Unsorted array:");

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }

        // Sort array
        Array.Sort(nums);

        Console.WriteLine("\nSorted array:");

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }

        Console.WriteLine("\nSimple array:");

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }

        // Reverse array
        Array.Reverse(nums);

        Console.WriteLine("\nReverse array:");

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }

        // Find index of an element
        int index = Array.IndexOf(nums, 5);

        Console.WriteLine("\nElement 5 is at index: " + index);
    }
}