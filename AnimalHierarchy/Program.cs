using System;

namespace AnimalHierarchy
{
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some sound");
        }
    }
    


    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }



    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }




    // Main program
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();

            Dog dog = new Dog();

            Cat cat = new Cat();

            // Call MakeSound() on each instance
            Console.WriteLine("Animal sound:");

            genericAnimal.MakeSound();

            Console.WriteLine("Dog sound:");

            dog.MakeSound();

            Console.WriteLine("Cat sound:");

            cat.MakeSound();
        }
    }
    Console.Readline();
}
