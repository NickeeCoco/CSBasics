using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOfChampions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String item1Name = "Slice of Big Rico Pizza";
            decimal item1Price = 500.00M;

            String item2Name = "Invisible Strawberry Pie";
            decimal item2Price = 2.00M;

            String item3Name = "Denver Omelet";
            decimal item3Price = 1.50M;


            Console.WriteLine(".oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.");
            Console.WriteLine();
            Console.WriteLine("WELCOME TO RESTAURANT NIGHT VALE!");
            Console.WriteLine("Today's Menu Is...");
            Console.WriteLine();
            Console.WriteLine(".oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.");
            Console.WriteLine();
            Console.WriteLine("$ " + item1Price + " *** " + item1Name);
            Console.WriteLine("$ " + item2Price + " ***** " + item2Name);
            Console.WriteLine("$ " + item3Price + " ***** " + item3Name);
        }
    }
}
