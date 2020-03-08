using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap Output Program");

            Console.WriteLine("Enter The First Number?");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter The Second Number?");
            string secondNumber = Console.ReadLine();

            int secondNumberConverted = int.Parse(firstNumber);

            int firstNumberConverted = int.Parse(secondNumber);

            Console.WriteLine("The first number is:"+firstNumberConverted);
            Console.WriteLine("The Second number is:"+secondNumberConverted);
            Console.ReadLine();


        }
    }
}
