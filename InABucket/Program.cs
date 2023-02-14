using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InABucket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can declare all KINDS of variables.
            String walrus;
            double piesEaten;
            float weightOfTeacupPig;
            int grainsOfSand;

            // But declaring them just sets up the space for data.
            // If you want to use the variable, you have to put data IN it first!
            walrus = "Sir Leroy Jenkins III";
            piesEaten = 42.1;
            weightOfTeacupPig = 3.5F;
            grainsOfSand= 258462154;

            Console.WriteLine("Meet my pet walrus, " + walrus);
            Console.Write("He was a bit hungry today and ate this many pies: ");
            Console.WriteLine(piesEaten);
            Console.Write("I can't belive this teacup pig weighs " + weightOfTeacupPig + " pounds");
            Console.WriteLine(" and can hold " + grainsOfSand + "grains of sand!");

        }
    }
}
