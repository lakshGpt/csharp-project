using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public class encapsulation
    {
        private string name;
        private int age;

        private void getter()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        private void setter(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void getDetails()
        {
            this.getter();
        }

        public void setDetails(string name , int age)
        {
            this.setter(age, name);
        }
    }
}
