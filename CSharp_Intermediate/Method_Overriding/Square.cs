using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
   public class Square : Shapes
    {
       public int length { get; set; }

       public Square(int length)
        {
            this.length = length;
        }

        public override int area()
        {
            return length * 4;
        }
    }
}
