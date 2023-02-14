using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Nickee Coco";
            String favoriteFood = "burgers";
            int numberOfPets = 2;
            String livingPlace = "condo";
            bool canWhistle = true;

            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("My favorite food is " + favoriteFood + ".");
            Console.WriteLine("I have " + numberOfPets + " pets.");
            Console.WriteLine("I live in a " + livingPlace + " and I love it there.");
            Console.WriteLine("It is " + canWhistle + " that I know how to whistle.");

        }
    }
}
