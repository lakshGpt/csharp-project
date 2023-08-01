using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    interface Iemployee
    {
        void show();
    }

    public class child : Iemployee 
    {
        public void show()
        {
            Console.WriteLine("this is interface");
        }
    }
}
