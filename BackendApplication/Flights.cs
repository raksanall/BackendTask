using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication
{
    
    public class Flights
    {
        Dictionary<int, Flight> allFlights= new();
    

        public Flights()
        {
           
        }

        public void AddFlight(int id,Flight flight)
        {
            allFlights.Add(id, flight);

        }
       
    }
}
