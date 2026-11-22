using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSProject
{
    internal class HomeWork
    {
        static void Main(string[] args)
        {
            // task 1
            /*
            Console.Write("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Convert (1 - F to C, 2 - C to F): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                double celsius = (temp - 32) * 5 / 9;
                Console.WriteLine("Result: " + celsius + " C");
            }
            else if (choice == 2)
            {
                double fahrenheit = temp * 9 / 5 + 32;
                Console.WriteLine("Result: " + fahrenheit + " F");
            }
            else
                Console.WriteLine("Invalid choice");
            */
            // task 2
            /*
            Console.Write("Enter start number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.Write("Even numbers: ");
            for (int i = start; i <= end; i++)
                if (i % 2 == 0)
                    Console.Write(i + " ");
            Console.WriteLine();
            */
            // task 3
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number;
            int digitsCount = 0;

            while (temp > 0)
            {
                digitsCount++;
                temp /= 10;
            }

            temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                int power = 1;

                for (int i = 0; i < digitsCount; i++)
                    power *= digit;

                sum += power;
                temp /= 10;
            }

            if (sum == number)
                Console.WriteLine(number + " is an Armstrong number");
            else
                Console.WriteLine(number + " is not an Armstrong number");
        }
    }
}
