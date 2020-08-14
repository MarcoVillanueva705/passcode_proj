using System;

namespace passcode_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";

            while (code != "frites")
            {

                Console.WriteLine("Please enter the secret word!");
                code = Console.ReadLine();

                if (code == "frites")
                {
                    Console.WriteLine("You may enter...");
                }
                else if (code != "frites")
                {
                    Console.WriteLine("Incorrect...try again");

                }
            }
        }
    }
}
