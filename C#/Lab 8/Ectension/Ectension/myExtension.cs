using System;
using System.Collections.Generic;
using System.Text;

namespace EXtension
{
    public static class myExtension
    {
        public static void Display_price(this Product p)
        {
            Console.WriteLine("Price = " + p.price);
        }
        public static void Display_supplier(this Supplier s)
        {
            Console.WriteLine("ID = " + s.Id);
            Console.WriteLine("Name = " + s.name);
            Console.WriteLine("City =" + s.city);
        }
    }
}
