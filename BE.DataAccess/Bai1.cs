using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess
{
    public static class Bai1
    {
        public static void AddTwoNumbers()
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string number2 = Console.ReadLine();

            var isValid1 = NET_BE.Common.ValidateData.CheckInput(number1);
            var isValid2 = NET_BE.Common.ValidateData.CheckInput(number2);

            if (!isValid1 || string.IsNullOrEmpty(number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (!isValid2 || string.IsNullOrEmpty(number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            int result = int.Parse(number1) + int.Parse(number2);
            Console.WriteLine($"The sum of {number1} and {number2} is {result}");
        }

        public static void SubtractTwoNumbers()
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string number2 = Console.ReadLine();

            var isValid1 = NET_BE.Common.ValidateData.CheckInput(number1);
            var isValid2 = NET_BE.Common.ValidateData.CheckInput(number2);

            if (!isValid1 || string.IsNullOrEmpty(number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (!isValid2 || string.IsNullOrEmpty(number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            int result = int.Parse(number1) - int.Parse(number2);
            Console.WriteLine("The different between {0} and {1} is {2}", number1, number2, result);
        }

        public static void MultiplyTwoNumbers()
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string number2 = Console.ReadLine();

            var isValid1 = NET_BE.Common.ValidateData.CheckInput(number1);
            var isValid2 = NET_BE.Common.ValidateData.CheckInput(number2);

            if (!isValid1 || string.IsNullOrEmpty(number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (!isValid2 || string.IsNullOrEmpty(number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            int result = int.Parse(number1) * int.Parse(number2);
            Console.WriteLine("The product of {0} and {1} is {2}", number1, number2, result);
        }
    }
}
