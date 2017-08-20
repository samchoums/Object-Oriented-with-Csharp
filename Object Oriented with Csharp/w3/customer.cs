using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ToW5
{
    class customer
    {
        string name;
        string address;
        string passportNumber;
        DateTime dateOfBirth;

        public customer(string name, string address, string passportNumber, DateTime dateOfBirth) 
        {
            this.name = name;
            this.address = address;
            this.passportNumber = passportNumber;
            this.dateOfBirth = dateOfBirth;
        }

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

        public string Passport
        {
            get
            {
                return passportNumber;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
        }

        public int GetAge
        {
            get
            {
                return DateTime.Now.Year - dateOfBirth.Year;
            }
        }

        //public void showCustomer()
        //{
        //    Console.WriteLine(" name:{0},address:{1},passportNumber:{2}, dateOfBirth:{3}", name, address, passportNumber, dateOfBirth);
        //}

        public override string ToString()
        {
            string a = string.Format(" name:{0},address:{1},passportNumber:{2}, dateOfBirth:{3}", name, address, passportNumber, dateOfBirth);
            return a;
        }

    }

}
