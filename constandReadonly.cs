using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    static class constandReadonly
    {
        public const int constant = 100; // compile time constant

        public static readonly double pi; // run time constant
        //it is define in constructor

        static constandReadonly()
        {
            pi = 3.14;
        }
    }
}
