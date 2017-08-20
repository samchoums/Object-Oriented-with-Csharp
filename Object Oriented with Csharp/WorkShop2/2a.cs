using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop2
{
    class _2a
    {
        static void Main()
        {
            //Triangle
            Triangle a = new Triangle();  //attributes, method    
            Console.WriteLine(a.Area(5, 12, 13));

            //Triangle2
            triangle2 b = new triangle2(3, 4, 5);  //attributes, constructors, properties
             Console.WriteLine(b.Area);

            //rectangle
            Rectangle c = new Rectangle(3, 5);
            Console.WriteLine(c.area);
      c.show();

           
        }

    }
}
