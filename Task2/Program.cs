using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Calculator");

            Console.WriteLine("Enter The First Number?");
            string num1=Console.ReadLine();
            double num1Converted = double.Parse(num1);
            Console.WriteLine("Enter The Second Number?");
            string num2 = Console.ReadLine();
            double num2Converted = double.Parse(num2);
            Console.WriteLine("Enter The Third Number?");
            string num3 = Console.ReadLine();
            double num3Converted = double.Parse(num3);
            Console.WriteLine("Enter The Fourth Number?");
            string num4 = Console.ReadLine();
            double num4Converted = double.Parse(num4);

            double averageNumber = (num1Converted + num2Converted + num3Converted + num4Converted) / 4;

            Console.WriteLine(averageNumber);
            Console.ReadLine();
        }
    }
}
