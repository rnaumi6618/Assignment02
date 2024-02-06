using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Dimension Calculator");
            Rectangle myRectangle = new Rectangle();

            int length, width;

            // Get length from user with validation
            Console.Write("Please enter the length of the rectangle: ");
            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer for length.");
                Console.Write("Please enter the length of the rectangle: ");
            }
            myRectangle.SetLength(length);

            // Get width from user with validation
            Console.Write("Please enter the width of the rectangle: ");
            while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer for width.");
                Console.Write("Please enter the width of the rectangle: ");
            }
            myRectangle.SetWidth(width);

            //Calculate and display the perimeter
            Console.WriteLine($"The perimeter of the rectangle is: {myRectangle.GetPerimeter()}");

            //k Calculate and display the area
            Console.WriteLine($"The area of the rectangle is: {myRectangle.GetArea()}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
