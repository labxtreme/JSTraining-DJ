using System;
using System.Collections.Generic;
using System.Text;

namespace EXtension
{
    public class Supplier
    {
        public int Id;
        public string name, city;
        public Supplier(int id, string n, string c)
        {
                this.city = c;
                this.name = n;
                this.Id = id;
        }
    }
}
