using System;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("For Loop");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nWhile Loop");

        int a = 1;

        while (a <= 5)
        {
            int result = a * 2;

            Console.WriteLine("2 x " + a + " = " + result);

            a++;
        }
        string[] names = {"Ali", "Bilal"};
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}