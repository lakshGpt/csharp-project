using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public class employee
    {
        private int emp_id;
        private string emp_name;
        private int GrossPay;

        double netSalary;
        double TaxDeduction = 0.1;

        public employee(int emp_id,string emp_name,int Grosspay) 
        { 
            this.emp_id = emp_id; this.emp_name = emp_name; this.GrossPay = Grosspay;
        }

        private void calculateSalary( ) 
        {
            if(GrossPay >= 36000)
            {
                netSalary = GrossPay + (TaxDeduction*GrossPay);
                Console.WriteLine("your salary is: " + netSalary);
            }
            else
            {
                Console.WriteLine("your salary is: " + GrossPay);
            }
        }

        public void showDetails()
        {
            this.calculateSalary();
        }
    }
}
