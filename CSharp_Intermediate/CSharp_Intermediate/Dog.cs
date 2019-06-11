using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
   public class Dog
    {
        private Animal _animal = new Animal();

        public Dog(Animal anim)
        {
            _animal = anim;
        }

        public void RecordType()
        {
            _animal.AnimalIdentifer("This is a Dog");
        }
    }
}
