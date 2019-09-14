using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    public class Shapes : Abstract_Shape
    {
       public Shapes()
        {

        }

       override public int area()
        {
            return 63;
        }
    }
}
