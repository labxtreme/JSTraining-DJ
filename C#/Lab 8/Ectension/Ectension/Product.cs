using System;
using System.Collections.Generic;
using System.Text;

namespace EXtension
{
    public class Product
    {
        public int Id { get; set; } 
        public int price{get; set;}
        public string title { get; set; }

        public void display()
        {
            Console.WriteLine("ID = "+this.Id);
            Console.WriteLine("Price = "+this.price);
            Console.WriteLine("Title ="+this.title);

        }


    }
}
