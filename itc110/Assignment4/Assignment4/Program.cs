using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        /*1. Create a for loop that displays 10 random numbers. Random is an object that produces a random number. Below is a piece of code that produces a random number between 1 and 50:

Random rand = new Random();
rand.Next(1,51);
2. Create a for loop that counts down (and displays the count) from 10 to 0.

3. Create a while loop that displays the count of the loops and then asks the user whether they want to continue or not. If yes, then continue; if no the program should end and display a a note saying thank you.

Create a do loop that runs until a user enters "Stop."
         *  BLAKE SCHWARTZ
 * SECTION 3192 MW EVENING CLASS
 * ASSIGNMENT 4 10/8/2014 PART 4
*/
        static void Main(string[] args)
        {
          /* 1. Random rand = new Random();
            for(int i=0;i<10;i++)
            {
                int number = rand.Next(1, 51);
                Console.WriteLine(number);
            } */// End 1.

            /* 2. 
            for (int i = 10; i > 0;i-- )
            {
                Console.WriteLine(i);
            } */// End 2.

            /*
            string go = "yes";
            int counter = 0;
            while(go.Equals("yes") || go.Equals("yes"))
            {
                counter++;
                Console.WriteLine("You have done {0} loops.", counter);
                Console.WriteLine("Do you want to do another? Yes or No?");
                go = Console.ReadLine();
            }
            Console.WriteLine("Thank you.");
            */// End 3

            string go = "yes";
            do
            {
                Console.WriteLine("Do you want to continue? Type stop to stop.");
                go = Console.ReadLine();
                go = go.ToLower();
            }
            while (!go.Equals("stop"));
                Console.ReadKey();
        }
    }
}
