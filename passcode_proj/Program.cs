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
                //code starts as an empty string on line 9
                //code on line 20 is what user enters in terminal
                code = Console.ReadLine();
                //when user enters 'frites', code breaks out of loop
                if (code == "frites")
                {
                    //end of loop
                    Console.WriteLine("You may enter...");
                }
                //this kicks the loop back to 'please enter the secret word!'
                //if user enters incorrect code on line 20
                else if (code != "frites")
                {
                    Console.WriteLine("Incorrect...try again");

                }
            }
        }
    }
}
