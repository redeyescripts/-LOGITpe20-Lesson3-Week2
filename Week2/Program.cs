using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, Whats your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);

            Console.WriteLine("What Year are you born in?");
            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            Console.WriteLine("You are " + Age + "years old.");
            ///Console.WriteLine("hello!," + Name + Year);
            Console.WriteLine("Go home "+ Name !);
            string No;
                 = Console.ReadLine("No, " + );
            
           

        }


    }
}
