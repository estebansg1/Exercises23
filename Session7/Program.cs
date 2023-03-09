using System;
//Exercise 1
namespace AbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine("The absolute difference is {0} and double of the absolute difference is {1}", difference, 2 * difference);
            }
            else
            {
                Console.WriteLine("The absolute difference is {0}", difference);
            }

            Console.ReadLine();
        }
    }
}
