using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Place
    {
        protected double rentPrice;
        protected string size;
        protected bool open;

        public Place(double rentPrice, string size, bool open = false)
        {
            this.rentPrice = rentPrice;
            this.size = size;
        }

        public double GASRentPrice
        {
            get { return this.rentPrice; }
            set
            {
                if (value < 0) return;
                this.rentPrice = value;
            }
        }
        public string GASsIZE
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public abstract void OpenThePlase();
        public abstract void CloseThePlase();
    }

}
