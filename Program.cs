using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store(0, "0.25 DONAM", true);
            Console.WriteLine(s);
            Console.WriteLine(s.GASEdibleItemS[0]);
            s.GASEdibleItemS[0] = new EdibleItem("Bamba", 1, 10, 3.90);
            s.GASEdibleItemS[1] = new EdibleItem("Bisli", 2, 5, 4.90);
            s.GASEdibleItemS[2] = new EdibleItem("Milk", 3, 6, 6.90);
            foreach (EdibleItem i in s.GASEdibleItemS)
            {
                Console.WriteLine(i);
            }
            s.GASEdibleItemS[1].DEC();s.GASEdibleItemS[1].DEC();s.GASEdibleItemS[1].DEC();s.GASEdibleItemS[1].DEC();
            s.GASEdibleItemS[1].DEC();s.GASEdibleItemS[1].DEC();s.GASEdibleItemS[1].DEC();
            Console.WriteLine(s.GASEdibleItemS[1]);
            Console.WriteLine(s.GASEdibleItemS[1].GASPrice);
            s.GASEdibleItemS[1].GASPrice = 5.90;
            Console.WriteLine(s.GASEdibleItemS[1].GASPrice);
            Console.WriteLine(s.GASEdibleItemS[1].GASName);
            s.GASEdibleItemS[1].GASName = "Bisli+";
            Console.WriteLine(s.GASEdibleItemS[1].GASName);
            Console.WriteLine(s);
            s.OpenThePlase();
            Console.WriteLine(s);
            Console.WriteLine(s.GASRentPrice);
            s.GASRentPrice = 5000;
            Console.WriteLine(s.GASRentPrice);
        }
    }
}
