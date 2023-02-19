using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
   public class Flights
    {
        private int flightId;
        private DateTime flightDate;
        private int estimateduration;
        private DateTime effectivearrival;
        private string departure;
        private string destination;

        public int FlightID { get; set; }
        public DateTime FlightDate { get; set; }

        public int EstimationDuration { get; set; }

       public  DateTime EffectiveArrival { get; set; }


        public string Departure { get; set; }

        public string  Destination { get; set; }
        public Plane Plane { get; internal set; }
        public IList<Passenger> Passengers { get; set; }
    }
}
