using System;

namespace week2_lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, pick a number!");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
           /// Console.WriteLine("Pick a second number");
            ///UserInput = Console.ReadLine();
            ///int Num2 = Int32.Parse(UserInput);
            if(Num1 > 0)
        Console.WriteLine("This number is postive");
            if (Num1 == 0)
                Console.WriteLine("This number is equal to zero");
            else

                Console.WriteLine("This number is negative");
        }
    }
    }

