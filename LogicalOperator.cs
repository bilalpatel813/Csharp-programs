using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello sir, hope today was a productive day.");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        int age = 20;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);

        if (name == "bilal" && age == 19)
        {
            Console.WriteLine("Admin access given.");
        }
        else if (name == "bilal" || age == 20)
        {
            Console.WriteLine("Happiest 20th birthday sir.");
        }
        else
        {
            Console.WriteLine("Only admin access.");
        }
    }
}