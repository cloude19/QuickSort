using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
   public class Cat
    {
        Animal _animal = new Animal();

        public Cat(Animal anim)
        {
            _animal = anim;
        }

        public void RecordType()
        {
            _animal.AnimalIdentifer("this is a cat");
        }
    }
}
