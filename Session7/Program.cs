using System;
//Exercise 1
namespace AbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            double num1;
            double num2; 
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
