using System;
using System.Collections.Generic;
using System.Text;

namespace UpandDownCasting
{
    public class Dog : Animal
    {
        public string type;
        public string furColor;

       public Dog(string name, int age)
            :base(name, age)
        {

        }
    }
}
