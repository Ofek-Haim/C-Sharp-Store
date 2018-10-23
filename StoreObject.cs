using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class StoreObject
    {
        protected string name;
        protected bool edible;
        protected int id;

        public StoreObject(int id, string name = "", bool edible = false)
        {
            this.id = id;
            this.name = name;
            this.edible = edible;
        }
        public int GASId
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string GASName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool GASEdible
        {
            get { return this.edible; }
            set { this.edible = value; }
        }
    }
}
