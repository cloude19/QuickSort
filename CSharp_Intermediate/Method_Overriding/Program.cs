using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    class Program
    {
        public static List<Shapes> shapesContainer = new List<Shapes>();

        static void Main(string[] args)
        {
            shapesContainer.Add(new Square(4));
            shapesContainer.Add(new Circle(6));

            var value = shapesContainer[1].area();

            Console.WriteLine(value);
        }
    }
}
