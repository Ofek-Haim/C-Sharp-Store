using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store : Place
    {
        protected EdibleItem[] EdibleItemS;

        public Store(double rentPrice, string size, bool open = false) : base(rentPrice, size, open)
        {
            EdibleItemS = new EdibleItem[3];
        }
        public EdibleItem[] GASEdibleItemS
        {
            get { return this.EdibleItemS; }
            set { this.EdibleItemS = value; }
        }
        public override void OpenThePlase()
        {
            this.open = true;
        }
        public override void CloseThePlase()
        {
            this.open = false;
        }
        public override string ToString()
        {
            return "rentPrice = " + this.rentPrice + " size = " + this.size + " open = " + this.open;
        }
    }
}
