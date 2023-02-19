using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        private string healthinformation;
        private string nationality;

        public string HealthInformation { get; set; }
        public string Nationnality { get; set; }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("Im aycha , the traveller ");

        }
    }
}
