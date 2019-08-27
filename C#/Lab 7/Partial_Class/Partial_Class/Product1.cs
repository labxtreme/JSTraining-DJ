using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Class
{
    public partial class Product
    {
        Int32 price;
        string title, color;
        public Product()
        {
                this.price = 100;
                this.title = "Foo";
                this.color = "Red";
        }
        public Product(int p, string t)
        {
            this.price = p;
            this.title = t;
        }
        public Product(int p, string t, string c) : this(p,t)
        {
            this.color = c;
        }
        partial void Display_Price();
    }
}
