using System;

namespace AbsoluteDifference
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine()); 
            
            double difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine("The absolute difference is {0} and double of the absolute difference is {1}", difference, 2 * difference);
                double doubleDifference = 2 * difference;
            }
            else
            {
                Console.WriteLine("The absolute difference is {0}", difference);
            }

            Console.ReadLine();
        }
    }
}
