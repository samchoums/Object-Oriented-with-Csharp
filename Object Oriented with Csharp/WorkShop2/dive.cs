using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop2
{
    class dive
    {
        int faceUp;

        public dive() ////////////////////
        {
            faceUp = Throw();
        }
        public int GetFace()//////////////////////////////////
        {
            return faceUp;
        }
        public int Throw()
        {
            Random r = new Random();
            faceUp = r.Next(1, 20); /////////////////////
            return faceUp;
        }
        public string StrFaceUp()/////////////////////////////////   Didn't use it ? Tostring ?
        {
            //  int a = Throw();
            return (String.Format("GetFaceUp: {0}", GetFace()));
        }

        public int probability()////////////////////////
        {
            int count = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (GetFace() == 8)
                {
                    count = 1 / i;
                }
            }
            return count;
        }
    }
    public class game
    {
        static void Main()
        {
            dive a = new dive();
            Console.WriteLine("Face: {0},probability: {1}",a.GetFace(), a.probability());
            a.StrFaceUp();//////////////////??
        }
    }

}
