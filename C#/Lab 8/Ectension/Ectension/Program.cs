using System;

namespace EXtension
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Supplier b = new Supplier(101, "armin", "Jaipur");
            Product a = new Product
            {
                price = 100,
                Id = 12,
                title = "box"
            };
            a.display();
            a.Display_price();
            b.Display_supplier();
        }
    }
}
