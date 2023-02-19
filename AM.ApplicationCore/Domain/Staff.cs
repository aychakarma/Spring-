using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
   public class Staff : Passenger
    {
        private DateTime employmentdate;
        private double salary;
        private string function;

        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }
        public string Function { get; set; }

        public override void PassengerType()
        {
            // base iayyet lel msg eli fel passenger classe mére //base 
            Console.WriteLine("I'm the staff ");
        }
    }
}
