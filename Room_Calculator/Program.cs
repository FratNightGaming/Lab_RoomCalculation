using System;

namespace Room_Calculator
{
    class Program
    {
        public static float length;
        public static float width;
        public static float height;
        public static string overallSize;


        static void Main(string[] args)
        {
            

            Console.WriteLine("What is the length of the room (in feet)?");

            while (!float.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Try again. Please enter a numeric value for 'length'");
            }


            Console.WriteLine("What is the width of the room (in feet)?");

            while (!float.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Enter a numeric value for 'width'");
            }

            Console.WriteLine("What is the height of the room (in feet)?");

            while (!float.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Enter a numeric value for 'height'");
            }

            float area = length * width;

            Console.WriteLine();
            Console.WriteLine("The area of the room is: " + area + " square feet.");
            Console.WriteLine();

            float perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the room is: " + perimeter + " feet.");
            Console.WriteLine();

            float volume = length * width * height;

            float surfaceArea = (length * width * 2) + (height * width * 2) + (height * length * 2);

            Console.WriteLine("The volume of the room is: " + volume + " cubic feet.");
            Console.WriteLine();
            Console.WriteLine("The surface area of the room is: " + surfaceArea + " feet.");
            Console.WriteLine();

            /*switch (area)
            {
                case < 250:
                    Console.WriteLine();
                default:
                    break;
            }*/

            if (area < 250)
            {
                Console.WriteLine("You have a small room.");
            }

            if (area >= 250 && area < 650)
            {
                Console.WriteLine("You have a medium room.");
            }

            if (area > 650)
            {
                Console.WriteLine("You have a large room.");
            }
        }
    }
}
