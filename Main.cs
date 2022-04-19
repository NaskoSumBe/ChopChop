using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Stan

{
    class Program
    {
        static void Main()
        {
            int b = 1000;
            int h = 1000;
        }
       



        static string GetDay(int dayNum)
        {
            Console.WriteLine(GetDay(3));
            Console.ReadLine();
            string DayName;

            switch (dayNum)
            {
                case 0:
                    DayName = "Sunday";
                    break;

                case 1:
                    DayName = "Monday";
                    break;

                case 2:
                    DayName = "Tuesday";
                    break;

                case 3:
                    DayName = "Wednesday";
                    break;

                case 4:
                    DayName = "Thursday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;

                case 6:
                    DayName = "Saturday";
                    break;

                    default:
                    DayName = "Invalid day number";
                    break ;




            }



            return DayName; 

        }

        public static void betterCalculator()
        {
            Console.WriteLine("Enter your number here: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your operator here: ");
            string op = Console.ReadLine();
            Console.WriteLine("Enter your number here: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }


        }
        public static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num1 >= num2 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        class Calculator
        {
            static void calc()
            {

                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your second number ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + num2);
                Console.ReadLine();

            }

        }

        class YourName
        {

            private string name;

            public void WhatIsYourName()
            {

                Console.Write("Enter your name here: ");
                name = Console.ReadLine();
                Console.WriteLine(name + ",you are awesome! Now write your age below!");
                Console.Write("Your age is: ");
                string age = Console.ReadLine();
                Console.WriteLine(" Well, " + name + ", you are " + age + " years old.");

                Console.ReadLine();

            }

            public void storage()
            {

                int[] luckyNumber = {
        4,
        8,
        15,
        16,
        23,
        44
      };
                string[] friends = new string[10];
                friends[0] = "Stan";
                friends[1] = "Nedko";

                // luckyNumber[1] = 900; // Changing the value of 2nd int
                Console.WriteLine(friends[1]);
                Console.ReadLine();

            }

            public void tallMale()
            {
                bool isMale = true;
                bool isTall = true;

                if (isMale && isTall)
                {
                    Console.WriteLine("You are tall male");
                }
                else if (isMale && !isTall)
                {
                    Console.WriteLine("You are short male");
                }
                else if (!isMale && isTall)
                {
                    Console.WriteLine("You are short male");
                }
                else
                {
                    Console.WriteLine("You are not male or not tall");
                }



            }

            public static int GetMax(int num1, int num2, int num3)
            {
                int result;
                if (num1 >= num2 && num1 >= num3)
                {
                    result = num1;
                }
                else if (num1 >= num2 && num2 >= num3)
                {
                    result = num2;
                }
                else
                {
                    result = num3;
                }
                return result;

            }




        }

        class compare
        {
           
        }
    }
}
