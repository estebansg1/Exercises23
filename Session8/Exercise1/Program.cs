using System;

namespace Program
{
    class Rectangle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double perimeter = Math.Abs(width + width + height + height);
            double Area = Math.Abs(width * height);
            double Diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            {
                Console.WriteLine("The perimeter is {0}", perimeter);
                Console.WriteLine("The area is {0}", Area);
                Console.WriteLine("The Diagonal es {0}", Diagonal);
            }
        }
    }
}