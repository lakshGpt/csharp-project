using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public class parent
    {
        public virtual void Display()
        {
            Console.WriteLine("I'm a parent class");
        }
    }

    class childClass: parent 
    { 
        public override void Display() {
            Console.WriteLine("I'm a child class");
        }
    }

    class derivedClass : childClass 
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("this is derived class");
        }
    }
}
