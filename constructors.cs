using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public class constructors
    {
        private string name;
        private int age;
        private string collegeName;

        public constructors(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public constructors(constructors obj, string collegeName)
        {
            name = obj.name;
            age = obj.age;
            this.collegeName = collegeName;
        }

        public string Data
        {
            get
            {
                return (string.IsNullOrEmpty(collegeName)) ? ("The name of person is : " + name +
                       ",age of person is: " + age) :
                       ("The name of person is : " + name +
                       ",age of person is: " + age +
                       " and his/her college name is: " + collegeName);

            }
        }
    }
}
