using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise4
{
    class Program
    {
        static void Main(string[] args)

            // This lecture is about Arrays
            // An array is a variable that can store more than one value
           
        {
            string[] members = new string[4];
            members[0] = "Rebecca";
            members[1] = "George";
            members[2] = "Karen";
            members[3] = "Joe";

            Console.WriteLine("the Third member is {0}", members[2]);

            string[] colors;
            Console.WriteLine("How many colors do you want to enter");
            int number = int.Parse(Console.ReadLine());

            colors = new string[number];
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("enter Color");
                colors[i] = Console.ReadLine();
            }

            Console.WriteLine("*************");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            string[] dogs = new string[]
            { "spaniel", "pug", "husky", "dachshund" };

            Console.WriteLine("Choose a number 1 to 4");
            int dog = int.Parse(Console.ReadLine());

            Console.WriteLine("Your dog is {0}", dogs[dog-1]);

            Console.ReadKey();
        
        }

    }
}
