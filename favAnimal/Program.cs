using System;

namespace favAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, whats your favouite animal?");
            string UserInput;
            UserInput = Console.ReadLine();

            if (UserInput == "cat")
            {
                Console.WriteLine("You are a homebird");
            }
            else if (UserInput == "dog")
            {
                Console.WriteLine("You are a partygoer.");
            }

            else
            {

                Console.WriteLine($"You are a {UserInput} friend.");

            }
        }



    }
}