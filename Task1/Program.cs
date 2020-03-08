using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");

            string num1 = Console.ReadLine();
            double num1Converted = double.Parse(num1);

            Console.WriteLine("Enter The Second Number");

            string num2 = Console.ReadLine();
            double num2Converted = double.Parse(num2);

            Console.WriteLine("Enter The Operator");

            string operation= Console.ReadLine();
            

            switch (operation)
            {
                case "*":Console.WriteLine(num1Converted*num2Converted);
                    break;
                case "+": Console.WriteLine(num1Converted+num2Converted);
                    break;
                case "-": Console.WriteLine(num1Converted-num2Converted);
                    break;
                case "/": Console.WriteLine(num1Converted/num2Converted);
                    break;

                default: Console.WriteLine("This Calculator only accepts numbers, So Please check if you have made any input error");
                    break;
            };

                  


        }
    }
}
