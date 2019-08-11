using System;
using static System.Console;

namespace UpandDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {



            //upcasting
            Dog pluto = new Dog("pluto", 5);
            //downcasting
            pluto.setDogFields(pluto, "helicopter", "brown");

            /*Note: the methods below don't actually require
             upcasting/downcasting to work.*/

            //display name by upcasting
            var name = pluto as Animal;
            Console.WriteLine(name.GetNameandAge());

            //display type and furtype which where passed it's valeus by downcasting
            Console.WriteLine(pluto.type + pluto.furColor);

        }
    }
}
