using System;

namespace DemoMovable
{
    // Define the IMovable interface with Move method
    public interface IMovable
    {
        void Move();
    }


    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Main program to demonstrate the implementation
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable car = new Car();

            IMovable bicycle = new Bicycle();


            // Call Move() method on each instance
            Console.WriteLine("Testing IMovable implementations:");

            Console.WriteLine("-------------------------------");

            car.Move();

            bicycle.Move();

            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}
