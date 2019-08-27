using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_C_Sharp
{
    public class Log
    {
        static readonly DateTime FirstObj;
        static Log()
        {
            string[] abc = new string[1];

            FirstObj = DateTime.Now;
            string lines = "the first object was created at time " + FirstObj;
            abc[0] = lines; 

            System.IO.File.WriteAllLines(@"C:\Users\laksh\Desktop\time.txt", abc);
        }

        public void showtime()
        {
            string line = System.IO.File.ReadAllText(@"C:\Users\laksh\Desktop\time.txt");
            Console.WriteLine(line);

        }

    }
}
