using System;

namespace MyProgram
{
    public class Programs
    {
        public static void Main()
        {
            // Constructor Overloading

            Pizza p1 = new Pizza(
                "Stuffed Bread, ",
                "Mozzarella Cheese, ",
                "Extra Sauce"
            );

            Console.WriteLine(
                "Pizza with: "
                + p1.bread
                + p1.cheese
                + p1.sauce
                + p1.toppings
            );

            Console.ReadKey();
        }
    }

    public class Pizza
    {
        public string bread;
        public string cheese;
        public string sauce;
        public string toppings;

        // Constructor with all four ingredients
        public Pizza(string bread, string cheese, string sauce, string toppings)
        {
            this.bread = bread;
            this.cheese = cheese;
            this.sauce = sauce;
            this.toppings = toppings;
        }

        // Constructor with bread, sauce, and toppings
        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        // Constructor with bread and cheese
        public Pizza(string bread, string cheese,string sauce)
        {
            this.bread = bread;
            this.cheese = cheese;
            this.sauce = sauce;
        }
    }
}