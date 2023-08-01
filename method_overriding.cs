using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    
    public class Parent
    {
        public virtual void show()
        {
            Console.WriteLine("base classs is calling ");
        }
    }

    public class Child : Parent 
    {
        public override void show()
        {
            Console.WriteLine("child class is calling");
        }
    }
}
