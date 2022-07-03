using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    class SalarySlip
    {
        int fuel, medical, total=0;
        int basic_salary = 1500;

        void engineer()
        {
            fuel = 100;
            medical = 500;
            total = basic_salary + fuel + medical;
            Console.WriteLine("\n\nYour Total Salary with fuel and medical allowncess:\n\n" + total);
        }
        void manager()
        {
            fuel = 250;
            medical = 1000;
            total = basic_salary + fuel + medical;
            Console.WriteLine("\n\nYour Total Salary with fuel and medical allowncess:\n\n" + total);
        }
        void analyst()
        {
            fuel = 150;
            medical = 800;
            total = basic_salary + fuel + medical;
            Console.WriteLine("\n\nYour Total Salary with fuel and medical allowncess:\n\n" + total);
        }

        static void Main(string[] args)

        {
            int basic_salary = 1500;

            SalarySlip salarySlip = new SalarySlip();

            Console.WriteLine("Enter Your Designation\n 1: Engineer \n 2: Manager \n 3: Analyst \n");
            string designation = Console.ReadLine();

            Console.WriteLine("\n\nYour Designation is in this Company:\n\n" + designation + "\n\nAnd Your Basic Salary is:\n\n" + basic_salary);

            if (designation == "engineer" || designation == "1")
            {
                salarySlip.engineer();
            }
            else if (designation == "manager" || designation == "2")
            {
                salarySlip.manager();
            }
            else if (designation == "analyst" || designation == "3")
            {
                salarySlip.analyst();
            }
            else
            {
                Console.WriteLine("Your designation does not match with the current designations list.");
            }


        }


       


    }


}