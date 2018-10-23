using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class EdibleItem : StoreObject, IEdibleItem
    {
        protected int quantity;
        protected double price;

        public EdibleItem(string name, int id, int quantity, double price) : base(id, name, true)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public int GASQuantity
        {
            get { return this.quantity; }
            set
            {
                if (value < 0) return;
                this.quantity = value;
            }
        }

        public double GASPrice
        {
            get { return this.price; }
            set
            {
                if (value < 0) return;
                this.price = value;
            }
        }

        public void INC()
        {
            this.quantity++;
        }

        public void DEC()
        {
            if (this.quantity == 0) return;
            this.quantity--;
        }

        public bool Sold()
        {
            if (this.quantity == 0) return false;
            this.quantity--;
            return true;
        }

        public override string ToString()
        {
            return "name = " + this.name + " id = " + this.id + " quantity = " + this.quantity + " price = " + this.price + " edible = " + this.edible;
        }
    }
}
