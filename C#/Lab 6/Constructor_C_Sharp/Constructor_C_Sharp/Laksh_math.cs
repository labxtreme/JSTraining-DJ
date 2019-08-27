using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_C_Sharp
{
    public class Laksh_math  
    {   static int number;
        static int n1;
        public static void increment(int num, int incre)
        {
            number=num;
            n1 = incre;
        }
        public static void increment()
        {
            number += n1;
            Console.WriteLine("The number is " + number);
        }
        private Laksh_math()
        {

        }
    }
}
