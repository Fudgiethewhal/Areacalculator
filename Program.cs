using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will print the menu options and allow the user to enter their response and the answer will be provided 
            Console.WriteLine("Area Calculator");
            Console.WriteLine("Choose a shape to calculate its area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Square");
            Console.WriteLine("Enter your choice (1-4):");
            // This is used to take the user's choice as a string
            string choice = Console.ReadLine();

            switch (choice)
            {
                //Each option will provide the user with a choice 1-4 and user will be asked for height with case 3 and 4
                case "1":
                    // user will be asked to enter the radius of the circle
                    Console.Write("Enter the radius of the circle: ");
                    // user' input will convert the string input to a double number
                    double radius = double.Parse(Console.ReadLine());
                    // the calculation will occur here, using string interpolation, the F2 will provide two decimal places
                    Console.WriteLine($"The area of the circle is: {CalculateCircleArea(radius):F2}");
                    //the break is utilized as a stopping point so it does not calculate the other cases
                    break;

                case "2":
                    // user will input their base of the triangle here
                    Console.Write("Enter the base of the triangle: ");
                    // this reads the the user's input as a string
                    double baseLength = double.Parse(Console.ReadLine());
                    // user will enter the height of the triangle
                    Console.Write("Enter the height of the triangle: ");
                    // this will be stored in the 'height' variable
                    double height = double.Parse(Console.ReadLine());
                    // this will calculate the base and height of the triangle and display answer with 2 decimal places
                    Console.WriteLine($"The area of the triangle is: {CalculateTriangleArea(baseLength, height):F2}");
                    // the break is utilized as an end to this case process
                    break;

                case "3":
                    // user will input their base of the rectangle here
                    Console.Write("Enter the length of the rectangle: ");
                    // this reads the user's input as a string
                    double length = double.Parse(Console.ReadLine());
                    // user will enter the width of the rectangle
                    Console.Write("Enter the width of the rectangle: ");
                    // this will be stored as the 'width' variable
                    double width = double.Parse(Console.ReadLine());
                    // this will calculate the length and the width of the rectangle
                    Console.WriteLine($"The area of the rectangle is: {CalculateRectangleArea(length, width):F2}");
                    // the break is utilized as an end to this case process
                    break;

                case "4":
                    // user will enter their side length of the square
                    Console.Write("Enter the side length of the square: ");
                    // this will read the user's input as a string
                    double side = double.Parse(Console.ReadLine());
                    // user will calculate the are of the square
                    Console.WriteLine($"The area of the square is: {CalculateSquareArea(side):F2}");
                    // the break is utilized as an end to this case process
                    break;
            }
            // this will end the user's input and the user can then exit the application with pressing any key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // circle area method
        static double CalculateCircleArea(double radius)
        {
            // Formula: Area = π * r²
            return Math.PI * Math.Pow(radius, 2);
        }

        // triangle area method
        static double CalculateTriangleArea(double baseLength, double height)
        {
            // Formula: Area = 0.5 * base * height
            return 0.5 * baseLength * height;
        }

        // rectangle area method
        static double CalculateRectangleArea(double length, double width)
        {
            // Formula: Area = length * width
            return length * width;
        }

        // square area method
        static double CalculateSquareArea(double side)
        {
            // Formula: Area = side²
            return Math.Pow(side, 2);
            // this concludes the exercise 
        }
    }
}
