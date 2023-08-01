using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public class delegates
    {
        public delegate void addnum(int a,int b);
        public delegate void mulnum(int a, int b);

        public delegate void rectDelegate(double width, double height);
    
        public void sum(int a,int b)
        {
            Console.WriteLine($"sum of {a} & {b}= " +(a + b));
        }

        public void mul(int a,int b)
        {
            Console.WriteLine($"multiplication of {a} & {b}= " + (a * b));
        }

        public void perimeter(double a,double b)
        {
            Console.WriteLine($"perimeter of reactangle = "+(2*(a+b)));
        }

        public void area(double a,double b)
        {
            Console.WriteLine($"area of reactangle = "+(a*b));
        }
    }
}
