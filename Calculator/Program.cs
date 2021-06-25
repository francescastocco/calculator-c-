using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                  
            Console.WriteLine("Welcome to the calculator!");

            Console.Write("Please enter the operator:");
            string operator1;
            operator1 = Console.ReadLine();

            Console.Write("Please enter the first number:");
            string string1;
            string1 = Console.ReadLine();

            Console.Write("Please enter the second number:");
            string string2;
            string2 = Console.ReadLine();

            int number1 = int.Parse(string1);
            int number2 = int.Parse(string2);

            int result = 0;

            if (operator1 == "+")
            {
                result = number1 + number2;
            } else if (operator1 == "-") {
                result = number1 - number2;
            }
            else if (operator1 == "*")
            {
                result = number1 * number2;
            }
            else if (operator1 == "/")
            {
                result = number1 / number2;
            } 

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
