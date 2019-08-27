using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Class
{
    public partial class Product
    {
        partial void Display_Price() //
        {
            Console.WriteLine("The price of the Product is " + this.price);
        }

        public void Display()
        {
            Console.WriteLine($"The products title is {this.title} it costs {this.price} and the color is {this.color}\n ");
        }
    }
}
