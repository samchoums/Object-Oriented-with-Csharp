using System;

namespace Testing
{

    class Customer
    {
        private string name;
        private string address;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public Customer(string n, string a)
        {
            name = n;
            address = a;
        }

        //public override string ToString()
        //{
        //    string m = string.Format("{0},,,{1}",name, address);
        //    return m;
        //}
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street");
            int n = 65;
            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.WriteLine(n.ToString());
            Console.WriteLine(c.ToString());///////////////////////////////
            Console.WriteLine("{0}, {1}",c.Name,c.Address);
            Console.WriteLine("declare Tostring {0}",c); //declare Tostring first
        }



    }
}

