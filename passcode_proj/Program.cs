using System;

namespace passcode_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            //this is how the code perpetuates
            //as long as the code isn't 'frites'
            //keep prompting user to enter their
            //secret word
            while (code != "frites")
            {

                Console.WriteLine("Please enter the secret word!");
                code = Console.ReadLine();

                if (code == "frites")
                {
                    Console.WriteLine("You may enter...");
                }
                //this kicks the loop back to 'please enter the secret word!'
                else if (code != "frites")
                {
                    Console.WriteLine("Incorrect...try again");

                }
            }
        }
    }
}
