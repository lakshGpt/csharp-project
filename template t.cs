//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace c__tutorial
{
    public class template_t
    {
        public void Display<T>(T a)
        {
            Console.WriteLine(a);
            List<T> list = new List<T>();
            list.Add(a);
        }
    }
}
