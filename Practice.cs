//using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace FirstCSProject
//{
//    internal class Practice
//    {
//        static void Main(string[] args)
//        {
//            // task 1
//            /*
//            Console.WriteLine("It's easy to win forgiveness for being wrong;");
//            Console.WriteLine("\tbeing right is what gets you into real trouble");
//            Console.WriteLine("Bjarne Stroustrup
//            */
//            // task 2
//            /*
//            int num1 = Convert.ToInt32(Console.ReadLine());
//            int num2 = Convert.ToInt32(Console.ReadLine());
//            int num3 = Convert.ToInt32(Console.ReadLine());
//            int num4 = Convert.ToInt32(Console.ReadLine());
//            int num5 = Convert.ToInt32(Console.ReadLine());

//            int sum = num1 + num2 + num3 + num4 + num5;
//            int prod = num1 * num2 * num3 * num4 * num5;

//            int max = num1;
//            if (num2 > max) max = num2;
//            if (num3 > max) max = num3;
//            if (num4 > max) max = num4;
//            if (num5 > max) max = num5;
//            int min = num1;
//            if (num2 < min) min = num2;
//            if (num3 < min) min = num3;
//            if (num4 < min) min = num4;
//            if (num5 < min) min = num5;

//            Console.WriteLine($"Sum: {sum}");
//            Console.WriteLine($"Prod: {prod}");
//            Console.WriteLine($"Min: {min}");
//            Console.WriteLine($"Max: {max}");
//            */
//            // task 3
//            /*
//            string num = Console.ReadLine();
//            for (int i = num.Length - 1; i >= 0; i--) {
//                Console.Write(num[i]);
//            }
//            */
//            // task 4
//            /*
//            int start = Convert.ToInt32(Console.ReadLine());
//            int end = Convert.ToInt32(Console.ReadLine());

//            int a = 0;
//            int b = 1;
//            bool first = true;

//            while (a <= end)
//            {
//                if (a >= start)
//                {
//                    if (!first)
//                    {
//                        Console.Write(", ");
//                    }
//                    Console.Write(a);
//                    first = false;
//                }

//                int next = a + b;
//                a = b;
//                b = next;
//            }

//            Console.WriteLine();
//            */
//            // task 5
//            /*
//            int a = Convert.ToInt32(Console.ReadLine());
//            int b = Convert.ToInt32(Console.ReadLine());

//            for (int i = a; i <= b; i++)
//            {
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(i);
//                }
//                Console.WriteLine();
//            }
//            */
//            // task 6
//            /*
//            int length = Convert.ToInt32(Console.ReadLine());
//            char symbol = Convert.ToChar(Console.ReadLine());
//            string direction = Console.ReadLine();

//            if (direction == "horizontal")
//            {
//                for (int i = 0; i < length; i++)
//                {
//                    Console.Write(symbol);
//                }
//                Console.WriteLine();
//            }
//            else if (direction == "vertical")
//            {
//                for (int i = 0; i < length; i++)
//                {
//                    Console.WriteLine(symbol);
//                }
//            }
//            */
//            // task 7
//            /*
//            int n = Convert.ToInt32(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {
//                string s = i.ToString();
//                string rev = "";

//                for (int j = s.Length - 1; j >= 0; j--)
//                {
//                    rev += s[j];
//                }

//                if (s == rev)
//                {
//                    Console.Write(i + " ");
//                }
//            }
//            */
//            // task 8
//            int n = Convert.ToInt32(Console.ReadLine());

//            for (int row = 1; row <= n; row++)
//            {
//                for (int num = 1; num <= row; num++)
//                {
//                    Console.Write(num + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
