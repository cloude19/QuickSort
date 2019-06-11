using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog someDog = new Dog(new Animal());
            someDog.RecordType();

            Animal animal = new Animal();

            Cat someCat = new Cat(animal);
            someCat.RecordType();

            Console.WriteLine("Hello World!");
        }
    }
}
