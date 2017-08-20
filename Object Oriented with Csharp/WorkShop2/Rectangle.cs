using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop2
{
    class Rectangle
    {
        Double l, w;
        public Rectangle(double length, double width)
        {
            l = length;
            w = width;
        } 

        public double Length
        {
            get
            {
                return l;
            }
        }

        public double width
        {
            get
            {
                return w;
            }
        }
        public double area
        {
            get
            {
                double a = l * w;
                return a;
            }
        }

        /*
        public string StrValue()/////////////////////////////////////// 
        {
            return (String.Format("Rectangle: {0},{1}", l, w));
        }
        */

        public void show()
        {
            Console.WriteLine("Rectangle: {0},{1}", l, w);
        }
        
    }
}
