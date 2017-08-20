using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop2
{
    class Triangle //attributes,method
    {
        //attributes
        double s1 = 1, s2 = 2, s3 = 3;  // attributes is private, unless public

        //method 
        public double Side1()
        {
            return s1;
        }
        public double Side2()
        {
            return s2;
        }
        public double Side3()
        {
            return s3;
        }

        public double Area(double s1, double s2, double s3)
        {
            double s = (s1 + s2 + s3) / 2;
            double A = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
            return A;
        }
        public double Area()  // overloaded
        {
            double s = (s1 + s2 + s3) / 2;
            double A = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
            return A;
        }

        public double Perimeter()
        {
            double P = s1 + s2 + s3;
            return P;
        }
    }
}
