using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{

    public class ServiceFlight : IServiceFlight
    {
        public IList<Flights> flights { get; set; } = new List<Flights>();



        public IList<DateTime> GetFlightDates(string destination)
        {
            #region liste sans linq b foreach
            /*   IList<DateTime> dates = new List<DateTime>();
               foreach (var flight in flights)
               {   if (flight.Destination == destination)
                       dates.Add(flight.FlightDate);
               }

               return dates ;*/
            #endregion

            /* var query = from A in flights where A.Destination == destination
                             select A.FlightDate ;

             return query.ToList(); // to list bch ncastiwha 5ater par defaut traje3lik ennumerable wehna ncastiwha lil list 
             */
            return flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /*return (from A in flights
                    where A.FlightDate > startDate 
                    //&& (A.FlightDate - startDate).TotalDays < 7
                    && startDate.AddDays(7) < A.FlightDate
                    select A
                    ).Count();
                    ;*/

            // Lambda expression 

            // return flights.Where(A=> A.FlightDate > startDate && (A.FlightDate - startDate).TotalDays <7 
            //     ).Count();
            return flights.Count(A => A.FlightDate > startDate && (A.FlightDate - startDate).TotalDays < 7);
        }





        public void ShowFlightDeatils(Plane plane)
        {
            // var query = from R in plane.Flights select new { R.FlightDate , R.Destination};
            // var query = from R in flights
            //    where R.plane == plane

            /*var query = from R in plane.Flights 
                select new { R.FlightDate , R.Destination};*/

            var query = plane.Flights.Select(R => new { R.FlightDate, R.Destination });

            foreach (var item in query)
            {
                Console.WriteLine(item.FlightDate + item.Destination);
            }
        }

        public double DurationAverage(string destination)
        { // linq
            /*
            var query = from F in flights
                        where F.Destination == destination
                        select F.EsitimatedDuration;
            return query.Average();*/
            // lambda
            // return flights.Where(f=>f.Destination==destination).Select(f=>f.EsitimatedDuration).Average();
            return flights.Where(f => f.Destination == destination).Average(f => f.EsitimatedDuration);

        }

        public IEnumerable<Flights> OrderedDurationFlights()
        {   //par defaut asc : linq 
            /*
            var query = from F in flights
                        orderby F.EsitimatedDuration descending 
                        select F;
            return query;*/

            //lambda 
            // we don't need select phrase 
            //when u want to select a part of object u use select sinon noo need

            return flights.OrderByDescending(f => f.EstimationDuration);
        }

        public IEnumerable<Traveller> SeniorTravellers(Flights flight)
        {
            //LINQ
            /*  var query = from T in flight.passangers.OfType<Traveller>() //jibli lpassangers ala houwa traveller
                          orderby T.BrithDate
                          select T;
              return query.Take(3);
            */

            return flight.Passengers.OfType<Traveller>().OrderBy(t => t.BirthDate).Take(3);


        }
    }
}F
