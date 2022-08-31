using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace payrollConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            decimal hours;
            decimal rate;
            decimal gross;             //Gross = pay * hours

            //  Input fistname, lastname, hours, rate
            Console.Write("Input first name: ");
            firstname = Console.ReadLine();

            Console.Write("Input last name: ");
            lastname = Console.ReadLine();

            Console.Write("Input hours worked: ");
            hours = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Input hourly rate: ");
            rate = Convert.ToDecimal(Console.ReadLine());

            //  Calculate gross pay
            gross = hours * rate;

            //  Output everything
            Console.Clear();
            Console.WriteLine("First Name: " + firstname);
            Console.WriteLine("Last Name: " + lastname);
            Console.WriteLine("Hrs Worked " + hours.ToString("n2"));
            Console.WriteLine("Hrly Rate: " + rate.ToString("c"));
            Console.WriteLine("Gross Pay: " + gross.ToString("c"));

            Console.ReadLine();



        }
    }
}
