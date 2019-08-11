using System;
using System.Collections.Generic;
using System.Text;

namespace UpandDownCasting
{
    public class Animal
    {
        //Animal base class

       private string name { get; set; }
       private int age { get; set; }

       public Animal(string name, int age)
        {
            //implicit upcasting when passed in from derived classes
            this.name = name;
            this.age = age;
        }

        //pass dog as animal then downcast it to access dog fields
        public void setDogFields(Animal ani, string type, string furcolor)
        {
            //make sure object being passed in is a Dog
            if(ani is Dog dog){
                dog.type = type;
                dog.furColor = furcolor;
            }
        }

        public string GetNameandAge()
        {
            return $"{this.name} + {this.age} /n";
        }

    }
}
