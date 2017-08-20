using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop2
{
    class triangle2  
    {
        //attributes
        double s1, s2, s3;  // attributes is private(information hiding)unless use public 
        public triangle2(double side1, double side2, double side3) //Constructor without return, name should be the same as class
                                                                   //constructor is called automatically; initialize the attribute, then can use property to get the private value
        {
            Console.WriteLine("Overloaded Constructor is called automatically ");
            s1 = side1;
            s2 = side2;
            s3 = side3;
        }

        public triangle2() //Constructor without return
        {
        }

        // properties without(), and name should be different from attributes
        public double side1
        {
            get  //read  set = write
            {
                return s1;
            }
        }
        public double side2
        {
            get
            {
                return s2;
            }
        }
        public double side3
        {
            get
            {
                return s3;
            }
        }

        public double Area
        {
            get
            {
                double s = (s1 + s2 + s3) / 2;
                double A = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
                return A;
            }
        }
    }
}
