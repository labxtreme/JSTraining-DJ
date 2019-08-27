using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class CRUDSQL : ICRUD
    {
        public string get_name()
        {
            return "DJ SQL";
        }
         public int get_price()
        {
            return 9;
        }
       
    }

    class CRUDORACLE : ICRUD
    {
        public string get_name()
        {
            return "DJ Oracle";
        }
        public int get_price()
        {
            return 99;
        }

    }
}
