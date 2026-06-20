using System;

public class Test
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void Greet(string name)
    {
        Console.WriteLine("Hello\tMr. " + name);
    }

    public static void PrintInfo(string name, int age = 0)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age : " + age);
    }

    // Expression-bodied method
    public static void Mul(ref int x) => x *= 2;

    public static void OutMethod(out int z, out int y)
    {
        z = 8;
        y = 7;
    }

    public static int Calculate(int o)
    {
        int Helper(int n) => n * 2;

        return Helper(o) + 1;
    }

    public static void Main()
    {
        Console.WriteLine("Methods");

        Console.WriteLine("\nExpression-bodied methods");
        Console.WriteLine("Ref and Out");

        // ref parameter
        int val = 5;
        Mul(ref val);

        Console.WriteLine("2 x 5 = " + val);

        // out parameters
        int p, q;
        OutMethod(out p, out q);

        Console.WriteLine("p = " + p);
        Console.WriteLine("q = " + q);

        // Add method
        int result = Add(12, 40);
        Console.WriteLine("12 + 40 = " + result);

        // Greeting
        Greet("Bilal");

        // Default parameter
        PrintInfo("Bilal");
        PrintInfo("Bob", 16);

        // Local function
        Console.WriteLine("Calculate(5) = " + Calculate(5));
    }
}