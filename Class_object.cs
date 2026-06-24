using System;

namespace MyProgram
{
    public class Programs
    {
        public static void Main()
        {
            // Objects (instances) of the Car class
            Car car1 = new Car("Porsche");
            Car car2 = new Car("Mustang");
            Car car3 = new Car("Lambo");
            Car car4 = new Car() ;

            Console.WriteLine("Number of cars: " + Car.NumberOfCars);

            Car.Start();
            Car.Stop();
        }
    }

    public class Car
    {
        public string Name;

        // Static variable shared by all objects of the class
        public static int NumberOfCars;

        //  parameterized Constructor
        public Car(string name)
        {
            Name = name;

            Console.WriteLine("Name of car: " + Name);

            NumberOfCars++;
        }
        //Default constructor 
        public Car() 
        {
        	string name ="BMW";	
        	Console.WriteLine("name of car :"+name) ;
        } 
        public static void Start()
        {
            Console.WriteLine("Race is started!!");
        }

        public static void Stop()
        {
            Console.WriteLine("Race is stopped!");
        }
    }
}