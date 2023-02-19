using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        IList<DateTime> GetFlightDates(string destination);
        void ShowFlightDeatils(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);

        IEnumerable<Flights> OrderedDurationFlights();
        IEnumerable<Traveller> SeniorTravellers(Flights flight);
    }

}
