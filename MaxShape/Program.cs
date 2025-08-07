using System;

namespace MaxShape
{
    // Abstract base class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    //  class Circle derived from Shape
    public class Circle : Shape
    {
        private double radius;



        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }




    //  class Rectangle derived from 
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    // Main program
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(8.45);

            Rectangle rectangle = new Rectangle(9.0, 2.0);


            // Display their areas
            Console.WriteLine("Circle area: " + circle.GetArea().ToString("F2"));

            Console.WriteLine("Rectangle area: " + rectangle.GetArea().ToString("F2"));
        }
    }
}

